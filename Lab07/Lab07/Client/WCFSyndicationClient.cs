using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Client
{
    public partial class WCFSyndicationClient : Form
    {
        public WCFSyndicationClient()
        {
            InitializeComponent();
        }

        private void ATOM_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(@"http://localhost:8733/SyndicationService/feed/students" + "?format=atom");
                XmlElement root = xmlDoc.DocumentElement;

                XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
                nsmgr.AddNamespace("atom", "http://www.w3.org/2005/Atom");

                XmlNodeList entryNodes = root.SelectNodes("//atom:entry", nsmgr);

                StringBuilder atomContent = new StringBuilder();

                atomContent.Append("ATOM\n\n");

                foreach (XmlNode atomEntry in entryNodes)
                {
                    XmlNode titleNode = atomEntry.SelectSingleNode("atom:title", nsmgr);
                    string title = titleNode != null ? titleNode.InnerText : "";

                    XmlNode contentNode = atomEntry.SelectSingleNode("atom:content", nsmgr);
                    string noteId = contentNode != null ? contentNode.InnerText : "";

                    atomContent.Append("Subject: " + title + "\nNote ID: " + noteId + "\n\n");
                }

                richTextBox1.Text = atomContent.ToString();
        }

        private void RSS_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

                XmlDocument rssXmlDoc = new XmlDocument();

                rssXmlDoc.Load(@"http://localhost:8733/SyndicationService/feed/students" + "?format=rss");

                XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");

                StringBuilder rssContent = new StringBuilder();

                rssContent.Append("RSS\n\n");

                foreach (XmlNode rssNode in rssNodes)
                {
                    XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                    string title = rssSubNode != null ? rssSubNode.InnerText : "";

                    rssSubNode = rssNode.SelectSingleNode("link");
                    string link = rssSubNode != null ? rssSubNode.InnerText : "";

                    rssSubNode = rssNode.SelectSingleNode("description");
                    string noteId = rssSubNode != null ? rssSubNode.InnerText : "";

                    rssContent.Append("Subject: " + title + "\nNote ID: " + noteId + "\n\n");
                }
                richTextBox1.Text = rssContent.ToString();
        }

    }
}
