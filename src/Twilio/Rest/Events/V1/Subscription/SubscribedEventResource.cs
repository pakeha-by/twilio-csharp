/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// SubscribedEventResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Events.V1.Subscription
{

    public class SubscribedEventResource : Resource
    {
        private static Request BuildReadRequest(ReadSubscribedEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Events,
                "/v1/Subscriptions/" + options.PathSubscriptionSid + "/SubscribedEvents",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Retrieve a list of all Subscribed Event types for a Subscription.
        /// </summary>
        /// <param name="options"> Read SubscribedEvent parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedEvent </returns>
        public static ResourceSet<SubscribedEventResource> Read(ReadSubscribedEventOptions options,
                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<SubscribedEventResource>.FromJson("types", response.Content);
            return new ResourceSet<SubscribedEventResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Subscribed Event types for a Subscription.
        /// </summary>
        /// <param name="options"> Read SubscribedEvent parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedEvent </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SubscribedEventResource>> ReadAsync(ReadSubscribedEventOptions options,
                                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SubscribedEventResource>.FromJson("types", response.Content);
            return new ResourceSet<SubscribedEventResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Subscribed Event types for a Subscription.
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedEvent </returns>
        public static ResourceSet<SubscribedEventResource> Read(string pathSubscriptionSid,
                                                                int? pageSize = null,
                                                                long? limit = null,
                                                                ITwilioRestClient client = null)
        {
            var options = new ReadSubscribedEventOptions(pathSubscriptionSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Subscribed Event types for a Subscription.
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedEvent </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SubscribedEventResource>> ReadAsync(string pathSubscriptionSid,
                                                                                                        int? pageSize = null,
                                                                                                        long? limit = null,
                                                                                                        ITwilioRestClient client = null)
        {
            var options = new ReadSubscribedEventOptions(pathSubscriptionSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SubscribedEventResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SubscribedEventResource>.FromJson("types", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SubscribedEventResource> NextPage(Page<SubscribedEventResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Events)
            );

            var response = client.Request(request);
            return Page<SubscribedEventResource>.FromJson("types", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SubscribedEventResource> PreviousPage(Page<SubscribedEventResource> page,
                                                                 ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Events)
            );

            var response = client.Request(request);
            return Page<SubscribedEventResource>.FromJson("types", response.Content);
        }

        private static Request BuildCreateRequest(CreateSubscribedEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Events,
                "/v1/Subscriptions/" + options.PathSubscriptionSid + "/SubscribedEvents",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new Subscribed Event type for the subscription
        /// </summary>
        /// <param name="options"> Create SubscribedEvent parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedEvent </returns>
        public static SubscribedEventResource Create(CreateSubscribedEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Subscribed Event type for the subscription
        /// </summary>
        /// <param name="options"> Create SubscribedEvent parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedEvent </returns>
        public static async System.Threading.Tasks.Task<SubscribedEventResource> CreateAsync(CreateSubscribedEventOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Subscribed Event type for the subscription
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        /// <param name="type"> Type of event being subscribed to. </param>
        /// <param name="schemaVersion"> The schema version that the subscription should use. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedEvent </returns>
        public static SubscribedEventResource Create(string pathSubscriptionSid,
                                                     string type,
                                                     int? schemaVersion = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new CreateSubscribedEventOptions(pathSubscriptionSid, type){SchemaVersion = schemaVersion};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Subscribed Event type for the subscription
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        /// <param name="type"> Type of event being subscribed to. </param>
        /// <param name="schemaVersion"> The schema version that the subscription should use. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedEvent </returns>
        public static async System.Threading.Tasks.Task<SubscribedEventResource> CreateAsync(string pathSubscriptionSid,
                                                                                             string type,
                                                                                             int? schemaVersion = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new CreateSubscribedEventOptions(pathSubscriptionSid, type){SchemaVersion = schemaVersion};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchSubscribedEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Events,
                "/v1/Subscriptions/" + options.PathSubscriptionSid + "/SubscribedEvents/" + options.PathType + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Read an Event for a Subscription.
        /// </summary>
        /// <param name="options"> Fetch SubscribedEvent parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedEvent </returns>
        public static SubscribedEventResource Fetch(FetchSubscribedEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Read an Event for a Subscription.
        /// </summary>
        /// <param name="options"> Fetch SubscribedEvent parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedEvent </returns>
        public static async System.Threading.Tasks.Task<SubscribedEventResource> FetchAsync(FetchSubscribedEventOptions options,
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Read an Event for a Subscription.
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        /// <param name="pathType"> Type of event being subscribed to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedEvent </returns>
        public static SubscribedEventResource Fetch(string pathSubscriptionSid,
                                                    string pathType,
                                                    ITwilioRestClient client = null)
        {
            var options = new FetchSubscribedEventOptions(pathSubscriptionSid, pathType);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Read an Event for a Subscription.
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        /// <param name="pathType"> Type of event being subscribed to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedEvent </returns>
        public static async System.Threading.Tasks.Task<SubscribedEventResource> FetchAsync(string pathSubscriptionSid,
                                                                                            string pathType,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new FetchSubscribedEventOptions(pathSubscriptionSid, pathType);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateSubscribedEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Events,
                "/v1/Subscriptions/" + options.PathSubscriptionSid + "/SubscribedEvents/" + options.PathType + "",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Update an Event for a Subscription.
        /// </summary>
        /// <param name="options"> Update SubscribedEvent parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedEvent </returns>
        public static SubscribedEventResource Update(UpdateSubscribedEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update an Event for a Subscription.
        /// </summary>
        /// <param name="options"> Update SubscribedEvent parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedEvent </returns>
        public static async System.Threading.Tasks.Task<SubscribedEventResource> UpdateAsync(UpdateSubscribedEventOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update an Event for a Subscription.
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        /// <param name="pathType"> Type of event being subscribed to. </param>
        /// <param name="schemaVersion"> The schema version that the subscription should use. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedEvent </returns>
        public static SubscribedEventResource Update(string pathSubscriptionSid,
                                                     string pathType,
                                                     int? schemaVersion = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new UpdateSubscribedEventOptions(pathSubscriptionSid, pathType){SchemaVersion = schemaVersion};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update an Event for a Subscription.
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        /// <param name="pathType"> Type of event being subscribed to. </param>
        /// <param name="schemaVersion"> The schema version that the subscription should use. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedEvent </returns>
        public static async System.Threading.Tasks.Task<SubscribedEventResource> UpdateAsync(string pathSubscriptionSid,
                                                                                             string pathType,
                                                                                             int? schemaVersion = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new UpdateSubscribedEventOptions(pathSubscriptionSid, pathType){SchemaVersion = schemaVersion};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteSubscribedEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Events,
                "/v1/Subscriptions/" + options.PathSubscriptionSid + "/SubscribedEvents/" + options.PathType + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Remove an event type from a subscription.
        /// </summary>
        /// <param name="options"> Delete SubscribedEvent parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedEvent </returns>
        public static bool Delete(DeleteSubscribedEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Remove an event type from a subscription.
        /// </summary>
        /// <param name="options"> Delete SubscribedEvent parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedEvent </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSubscribedEventOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Remove an event type from a subscription.
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        /// <param name="pathType"> Type of event being subscribed to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedEvent </returns>
        public static bool Delete(string pathSubscriptionSid, string pathType, ITwilioRestClient client = null)
        {
            var options = new DeleteSubscribedEventOptions(pathSubscriptionSid, pathType);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Remove an event type from a subscription.
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        /// <param name="pathType"> Type of event being subscribed to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedEvent </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSubscriptionSid,
                                                                          string pathType,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteSubscribedEventOptions(pathSubscriptionSid, pathType);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a SubscribedEventResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SubscribedEventResource object represented by the provided JSON </returns>
        public static SubscribedEventResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SubscribedEventResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Account SID.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Type of event being subscribed to.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
        /// <summary>
        /// The schema version that the subscription should use.
        /// </summary>
        [JsonProperty("schema_version")]
        public int? SchemaVersion { get; private set; }
        /// <summary>
        /// Subscription SID.
        /// </summary>
        [JsonProperty("subscription_sid")]
        public string SubscriptionSid { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private SubscribedEventResource()
        {

        }
    }

}