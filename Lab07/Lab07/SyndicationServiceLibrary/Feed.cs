using Lab06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Xml;

namespace SyndicationServiceLibrary
{
    public class Feed : IFeed
    {
        public SyndicationFeedFormatter CreateFeed()
        {
            var feed = new SyndicationFeed("Feed Title", "A WCF Syndication Feed", null);
            feed.Items = CreateDefaultItems();

            var format = GetRequestedType();
     
            return CreateFormatter(feed, format);
        }

        public Stream GetStudentNotes(string format)
        {
            var feed = new SyndicationFeed("Subjects & Notes", "Get list of notes by all subjects for the student", null);
            feed.Items = GetStudentNotesItems();

            if (format?.ToLower() == "json")
            {
                var json = ConvertToJson(feed);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                return new MemoryStream(Encoding.UTF8.GetBytes(json));
            }

            var type = GetRequestedType();
            var formatter = CreateFormatter(feed, type);
            using (var memoryStream = new MemoryStream())
            {
                using (var writer = XmlWriter.Create(memoryStream))
                {
                    formatter.WriteTo(writer);
                    writer.Flush();

                    WebOperationContext.Current.OutgoingResponse.ContentType = "application/xml";

                    return new MemoryStream(memoryStream.ToArray());
                }
            }
        }


        private List<SyndicationItem> CreateDefaultItems()
        {
            var items = new List<SyndicationItem>
            {
                new SyndicationItem("An item", "Item content", null)
            };
            return items;
        }

        private List<SyndicationItem> GetStudentNotesItems()
        {
            var items = new List<SyndicationItem>();
            var notes = new StudentsModel(new Uri("http://localhost:52567/StudentService.svc/"));

            foreach (var note in notes.note.AsEnumerable())
            {
                var description = $"{note.id}. Note: {note.note1}. StudentID: {note.stud_id}";
                items.Add(new SyndicationItem(note.subject, description, null));
            }

            return items;
        }

        private string GetRequestedFormat()
        {
            return WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["format"];
        }

        private string GetRequestedType()
        {
            return WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["type"];
        }


        private SyndicationFeedFormatter CreateFormatter(SyndicationFeed feed, string format)
        {
            if (format == "atom")
            {
                return new Atom10FeedFormatter(feed);
            }
            else
            {
                return new Rss20FeedFormatter(feed);
            }
        }

        private string ConvertToJson(SyndicationFeed feed)
        {
            var feedData = new FeedData
            {
                Title = feed.Title.Text,
                Description = feed.Description.Text,
                Items = feed.Items.Select(item => new FeedItem
                {
                    Title = item.Title.Text,
                    Content = item.Content is TextSyndicationContent textContent ? textContent.Text : null,
                    PublishDate = item.PublishDate
                }).ToList()
            };

            using (var memoryStream = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(FeedData));
                serializer.WriteObject(memoryStream, feedData);
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
    }
}
