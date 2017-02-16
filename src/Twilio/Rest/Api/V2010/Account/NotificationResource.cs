using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// NotificationResource
    /// </summary>
    public class NotificationResource : Resource 
    {
        private static Request BuildFetchRequest(FetchNotificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Notifications/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch a notification belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Fetch Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static NotificationResource Fetch(FetchNotificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch a notification belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Fetch Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<NotificationResource> FetchAsync(FetchNotificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch a notification belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique notification Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static NotificationResource Fetch(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchNotificationOptions(sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch a notification belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique notification Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<NotificationResource> FetchAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchNotificationOptions(sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteNotificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Notifications/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Delete a notification identified by the NotificationSid from an accounts log
        /// </summary>
        ///
        /// <param name="options"> Delete Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static bool Delete(DeleteNotificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// Delete a notification identified by the NotificationSid from an accounts log
        /// </summary>
        ///
        /// <param name="options"> Delete Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteNotificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Delete a notification identified by the NotificationSid from an accounts log
        /// </summary>
        ///
        /// <param name="sid"> Delete by unique notification Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static bool Delete(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteNotificationOptions(sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Delete a notification identified by the NotificationSid from an accounts log
        /// </summary>
        ///
        /// <param name="sid"> Delete by unique notification Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteNotificationOptions(sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadNotificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Notifications.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of notifications belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static ResourceSet<NotificationResource> Read(ReadNotificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<NotificationResource>.FromJson("notifications", response.Content);
            return new ResourceSet<NotificationResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of notifications belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<NotificationResource>> ReadAsync(ReadNotificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<NotificationResource>.FromJson("notifications", response.Content);
            return new ResourceSet<NotificationResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of notifications belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="log"> Filter by log level </param>
        /// <param name="messageDateBefore"> Filter by date </param>
        /// <param name="messageDate"> Filter by date </param>
        /// <param name="messageDateAfter"> Filter by date </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static ResourceSet<NotificationResource> Read(string accountSid = null, int? log = null, DateTime? messageDateBefore = null, DateTime? messageDate = null, DateTime? messageDateAfter = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadNotificationOptions{AccountSid = accountSid, Log = log, MessageDateBefore = messageDateBefore, MessageDate = messageDate, MessageDateAfter = messageDateAfter, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of notifications belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="log"> Filter by log level </param>
        /// <param name="messageDateBefore"> Filter by date </param>
        /// <param name="messageDate"> Filter by date </param>
        /// <param name="messageDateAfter"> Filter by date </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<NotificationResource>> ReadAsync(string accountSid = null, int? log = null, DateTime? messageDateBefore = null, DateTime? messageDate = null, DateTime? messageDateAfter = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadNotificationOptions{AccountSid = accountSid, Log = log, MessageDateBefore = messageDateBefore, MessageDate = messageDate, MessageDateAfter = messageDateAfter, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<NotificationResource> NextPage(Page<NotificationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<NotificationResource>.FromJson("notifications", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a NotificationResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NotificationResource object represented by the provided JSON </returns> 
        public static NotificationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<NotificationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The version of the Twilio API in use
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The string that uniquely identifies the call
        /// </summary>
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }
        /// <summary>
        /// The date this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// A unique error code corresponding to the notification
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; private set; }
        /// <summary>
        /// An integer log level
        /// </summary>
        [JsonProperty("log")]
        public string Log { get; private set; }
        /// <summary>
        /// The date the notification was generated
        /// </summary>
        [JsonProperty("message_date")]
        public DateTime? MessageDate { get; private set; }
        /// <summary>
        /// The text of the notification.
        /// </summary>
        [JsonProperty("message_text")]
        public string MessageText { get; private set; }
        /// <summary>
        /// A URL for more information about the error code
        /// </summary>
        [JsonProperty("more_info")]
        public Uri MoreInfo { get; private set; }
        /// <summary>
        /// HTTP method used with the request url
        /// </summary>
        [JsonProperty("request_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod RequestMethod { get; private set; }
        /// <summary>
        /// URL of the resource that generated the notification
        /// </summary>
        [JsonProperty("request_url")]
        public Uri RequestUrl { get; private set; }
        /// <summary>
        /// Twilio-generated HTTP variables sent to the server
        /// </summary>
        [JsonProperty("request_variables")]
        public string RequestVariables { get; private set; }
        /// <summary>
        /// The HTTP body returned by your server.
        /// </summary>
        [JsonProperty("response_body")]
        public string ResponseBody { get; private set; }
        /// <summary>
        /// The HTTP headers returned by your server.
        /// </summary>
        [JsonProperty("response_headers")]
        public string ResponseHeaders { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this notification
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
    
        private NotificationResource()
        {
        
        }
    }

}