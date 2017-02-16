using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// ConferenceResource
    /// </summary>
    public class ConferenceResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
        
            public static readonly StatusEnum Init = new StatusEnum("init");
            public static readonly StatusEnum InProgress = new StatusEnum("in-progress");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
        }
    
        public sealed class UpdateStatusEnum : StringEnum 
        {
            private UpdateStatusEnum(string value) : base(value) {}
            public UpdateStatusEnum() {}
        
            public static readonly UpdateStatusEnum Completed = new UpdateStatusEnum("completed");
        }
    
        private static Request BuildFetchRequest(FetchConferenceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Conferences/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an instance of a conference
        /// </summary>
        ///
        /// <param name="options"> Fetch Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ConferenceResource Fetch(FetchConferenceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a conference
        /// </summary>
        ///
        /// <param name="options"> Fetch Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ConferenceResource> FetchAsync(FetchConferenceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an instance of a conference
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique conference Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ConferenceResource Fetch(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchConferenceOptions(sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a conference
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique conference Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ConferenceResource> FetchAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchConferenceOptions(sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadConferenceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Conferences.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of conferences belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ResourceSet<ConferenceResource> Read(ReadConferenceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<ConferenceResource>.FromJson("conferences", response.Content);
            return new ResourceSet<ConferenceResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of conferences belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ConferenceResource>> ReadAsync(ReadConferenceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<ConferenceResource>.FromJson("conferences", response.Content);
            return new ResourceSet<ConferenceResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of conferences belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="dateCreatedBefore"> Filter by date created </param>
        /// <param name="dateCreated"> Filter by date created </param>
        /// <param name="dateCreatedAfter"> Filter by date created </param>
        /// <param name="dateUpdatedBefore"> Filter by date updated </param>
        /// <param name="dateUpdated"> Filter by date updated </param>
        /// <param name="dateUpdatedAfter"> Filter by date updated </param>
        /// <param name="friendlyName"> Filter by friendly name </param>
        /// <param name="status"> The status of the conference </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ResourceSet<ConferenceResource> Read(string accountSid = null, DateTime? dateCreatedBefore = null, DateTime? dateCreated = null, DateTime? dateCreatedAfter = null, DateTime? dateUpdatedBefore = null, DateTime? dateUpdated = null, DateTime? dateUpdatedAfter = null, string friendlyName = null, ConferenceResource.StatusEnum status = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadConferenceOptions{AccountSid = accountSid, DateCreatedBefore = dateCreatedBefore, DateCreated = dateCreated, DateCreatedAfter = dateCreatedAfter, DateUpdatedBefore = dateUpdatedBefore, DateUpdated = dateUpdated, DateUpdatedAfter = dateUpdatedAfter, FriendlyName = friendlyName, Status = status, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of conferences belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="dateCreatedBefore"> Filter by date created </param>
        /// <param name="dateCreated"> Filter by date created </param>
        /// <param name="dateCreatedAfter"> Filter by date created </param>
        /// <param name="dateUpdatedBefore"> Filter by date updated </param>
        /// <param name="dateUpdated"> Filter by date updated </param>
        /// <param name="dateUpdatedAfter"> Filter by date updated </param>
        /// <param name="friendlyName"> Filter by friendly name </param>
        /// <param name="status"> The status of the conference </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ConferenceResource>> ReadAsync(string accountSid = null, DateTime? dateCreatedBefore = null, DateTime? dateCreated = null, DateTime? dateCreatedAfter = null, DateTime? dateUpdatedBefore = null, DateTime? dateUpdated = null, DateTime? dateUpdatedAfter = null, string friendlyName = null, ConferenceResource.StatusEnum status = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadConferenceOptions{AccountSid = accountSid, DateCreatedBefore = dateCreatedBefore, DateCreated = dateCreated, DateCreatedAfter = dateCreatedAfter, DateUpdatedBefore = dateUpdatedBefore, DateUpdated = dateUpdated, DateUpdatedAfter = dateUpdatedAfter, FriendlyName = friendlyName, Status = status, PageSize = pageSize, Limit = limit};
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
        public static Page<ConferenceResource> NextPage(Page<ConferenceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<ConferenceResource>.FromJson("conferences", response.Content);
        }
    
        private static Request BuildUpdateRequest(UpdateConferenceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Conferences/" + options.Sid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ConferenceResource Update(UpdateConferenceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ConferenceResource> UpdateAsync(UpdateConferenceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="status"> The status </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ConferenceResource Update(string sid, string accountSid = null, ConferenceResource.UpdateStatusEnum status = null, ITwilioRestClient client = null)
        {
            var options = new UpdateConferenceOptions(sid){AccountSid = accountSid, Status = status};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="status"> The status </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ConferenceResource> UpdateAsync(string sid, string accountSid = null, ConferenceResource.UpdateStatusEnum status = null, ITwilioRestClient client = null)
        {
            var options = new UpdateConferenceOptions(sid){AccountSid = accountSid, Status = status};
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ConferenceResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ConferenceResource object represented by the provided JSON </returns> 
        public static ConferenceResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ConferenceResource>(json);
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
        /// The api_version
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The region
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this conference
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The status of the conference
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConferenceResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The subresource_uris
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
    
        private ConferenceResource()
        {
        
        }
    }

}