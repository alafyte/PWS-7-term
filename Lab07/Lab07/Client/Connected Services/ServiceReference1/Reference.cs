﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IFeed")]
    public interface IFeed {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeed/CreateFeed", ReplyAction="http://tempuri.org/IFeed/CreateFeedResponse")]
        System.ServiceModel.Syndication.SyndicationFeedFormatter CreateFeed();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeed/CreateFeed", ReplyAction="http://tempuri.org/IFeed/CreateFeedResponse")]
        System.Threading.Tasks.Task<System.ServiceModel.Syndication.SyndicationFeedFormatter> CreateFeedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeed/GetStudentNotes", ReplyAction="http://tempuri.org/IFeed/GetStudentNotesResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.ServiceModel.Syndication.Atom10FeedFormatter))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.ServiceModel.Syndication.Rss20FeedFormatter))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.ServiceModel.Syndication.SyndicationFeedFormatter))]
        object GetStudentNotes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeed/GetStudentNotes", ReplyAction="http://tempuri.org/IFeed/GetStudentNotesResponse")]
        System.Threading.Tasks.Task<object> GetStudentNotesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFeedChannel : Client.ServiceReference1.IFeed, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FeedClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IFeed>, Client.ServiceReference1.IFeed {
        
        public FeedClient() {
        }
        
        public FeedClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FeedClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FeedClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FeedClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.ServiceModel.Syndication.SyndicationFeedFormatter CreateFeed() {
            return base.Channel.CreateFeed();
        }
        
        public System.Threading.Tasks.Task<System.ServiceModel.Syndication.SyndicationFeedFormatter> CreateFeedAsync() {
            return base.Channel.CreateFeedAsync();
        }
        
        public object GetStudentNotes() {
            return base.Channel.GetStudentNotes();
        }
        
        public System.Threading.Tasks.Task<object> GetStudentNotesAsync() {
            return base.Channel.GetStudentNotesAsync();
        }
    }
}
