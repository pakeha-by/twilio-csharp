/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Types;
using Twilio.Converters;

namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance
{

    /// <summary>
    /// Create a new Supporting Document.
    /// </summary>
    public class CreateSupportingDocumentOptions : IOptions<SupportingDocumentResource>
    {
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The type of the Supporting Document
        /// </summary>
        public string Type { get; }
        /// <summary>
        /// The set of parameters that compose the Supporting Documents resource
        /// </summary>
        public object Attributes { get; set; }

#if !NET35
        public IUploadFile File { get; set; }
#endif

        /// <summary>
        /// Construct a new CreateSupportingDocumentOptions
        /// </summary>
        /// <param name="friendlyName"> The string that you assigned to describe the resource </param>
        /// <param name="type"> The type of the Supporting Document </param>
        public CreateSupportingDocumentOptions(string friendlyName, string type)
        {
            FriendlyName = friendlyName;
            Type = type;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Serializers.JsonObject(Attributes)));
            }

            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of all Supporting Document for an account.
    /// </summary>
    public class ReadSupportingDocumentOptions : ReadOptions<SupportingDocumentResource>
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch specific Supporting Document Instance.
    /// </summary>
    public class FetchSupportingDocumentOptions : IOptions<SupportingDocumentResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSupportingDocumentOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchSupportingDocumentOptions(string pathSid)
        {
            PathSid = pathSid;
        }

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
    /// Update an existing Supporting Document.
    /// </summary>
    public class UpdateSupportingDocumentOptions : IOptions<SupportingDocumentResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The set of parameters that compose the Supporting Document resource
        /// </summary>
        public object Attributes { get; set; }

        /// <summary>
        /// Construct a new UpdateSupportingDocumentOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public UpdateSupportingDocumentOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Serializers.JsonObject(Attributes)));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete a specific Supporting Document.
    /// </summary>
    public class DeleteSupportingDocumentOptions : IOptions<SupportingDocumentResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteSupportingDocumentOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteSupportingDocumentOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}