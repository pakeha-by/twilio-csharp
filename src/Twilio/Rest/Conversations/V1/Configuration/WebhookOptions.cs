/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Conversations.V1.Configuration
{

    /// <summary>
    /// FetchWebhookOptions
    /// </summary>
    public class FetchWebhookOptions : IOptions<WebhookResource>
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateWebhookOptions
    /// </summary>
    public class UpdateWebhookOptions : IOptions<WebhookResource>
    {
        /// <summary>
        /// The HTTP method to be used when sending a webhook request.
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// The list of webhook event triggers that are enabled for this Service.
        /// </summary>
        public List<string> Filters { get; set; }
        /// <summary>
        /// The absolute url the pre-event webhook request should be sent to.
        /// </summary>
        public string PreWebhookUrl { get; set; }
        /// <summary>
        /// The absolute url the post-event webhook request should be sent to.
        /// </summary>
        public string PostWebhookUrl { get; set; }
        /// <summary>
        /// The routing target of the webhook.
        /// </summary>
        public WebhookResource.TargetEnum Target { get; set; }

        /// <summary>
        /// Construct a new UpdateWebhookOptions
        /// </summary>
        public UpdateWebhookOptions()
        {
            Filters = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method));
            }

            if (Filters != null)
            {
                p.AddRange(Filters.Select(prop => new KeyValuePair<string, string>("Filters", prop)));
            }

            if (PreWebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("PreWebhookUrl", PreWebhookUrl));
            }

            if (PostWebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("PostWebhookUrl", PostWebhookUrl));
            }

            if (Target != null)
            {
                p.Add(new KeyValuePair<string, string>("Target", Target.ToString()));
            }

            return p;
        }
    }

}