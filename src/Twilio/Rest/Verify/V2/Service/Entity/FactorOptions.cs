/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Verify.V2.Service.Entity
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Create a new Factor for the Entity
    /// </summary>
    public class CreateFactorOptions : IOptions<FactorResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique external identifier of the Entity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// A unique binding for this Factor as a json string
        /// </summary>
        public string Binding { get; }
        /// <summary>
        /// The friendly name of this Factor
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The Type of this Factor
        /// </summary>
        public FactorResource.FactorTypesEnum FactorType { get; }
        /// <summary>
        /// The config for this Factor as a json string
        /// </summary>
        public string Config { get; }
        /// <summary>
        /// The Twilio-Sandbox-Mode HTTP request header
        /// </summary>
        public string TwilioSandboxMode { get; set; }

        /// <summary>
        /// Construct a new CreateFactorOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="binding"> A unique binding for this Factor as a json string </param>
        /// <param name="friendlyName"> The friendly name of this Factor </param>
        /// <param name="factorType"> The Type of this Factor </param>
        /// <param name="config"> The config for this Factor as a json string </param>
        public CreateFactorOptions(string pathServiceSid,
                                   string pathIdentity,
                                   string binding,
                                   string friendlyName,
                                   FactorResource.FactorTypesEnum factorType,
                                   string config)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            Binding = binding;
            FriendlyName = friendlyName;
            FactorType = factorType;
            Config = config;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Binding != null)
            {
                p.Add(new KeyValuePair<string, string>("Binding", Binding));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (FactorType != null)
            {
                p.Add(new KeyValuePair<string, string>("FactorType", FactorType.ToString()));
            }

            if (Config != null)
            {
                p.Add(new KeyValuePair<string, string>("Config", Config));
            }

            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (TwilioSandboxMode != null)
            {
                p.Add(new KeyValuePair<string, string>("Twilio-Sandbox-Mode", TwilioSandboxMode));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Delete a specific Factor.
    /// </summary>
    public class DeleteFactorOptions : IOptions<FactorResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique external identifier of the Entity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// A string that uniquely identifies this Factor.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The Twilio-Sandbox-Mode HTTP request header
        /// </summary>
        public string TwilioSandboxMode { get; set; }

        /// <summary>
        /// Construct a new DeleteFactorOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Factor. </param>
        public DeleteFactorOptions(string pathServiceSid, string pathIdentity, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
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

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (TwilioSandboxMode != null)
            {
                p.Add(new KeyValuePair<string, string>("Twilio-Sandbox-Mode", TwilioSandboxMode));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Fetch a specific Factor.
    /// </summary>
    public class FetchFactorOptions : IOptions<FactorResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique external identifier of the Entity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// A string that uniquely identifies this Factor.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The Twilio-Sandbox-Mode HTTP request header
        /// </summary>
        public string TwilioSandboxMode { get; set; }

        /// <summary>
        /// Construct a new FetchFactorOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Factor. </param>
        public FetchFactorOptions(string pathServiceSid, string pathIdentity, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
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

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (TwilioSandboxMode != null)
            {
                p.Add(new KeyValuePair<string, string>("Twilio-Sandbox-Mode", TwilioSandboxMode));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a list of all Factors for an Entity.
    /// </summary>
    public class ReadFactorOptions : ReadOptions<FactorResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique external identifier of the Entity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// The Twilio-Sandbox-Mode HTTP request header
        /// </summary>
        public string TwilioSandboxMode { get; set; }

        /// <summary>
        /// Construct a new ReadFactorOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        public ReadFactorOptions(string pathServiceSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
        }

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

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (TwilioSandboxMode != null)
            {
                p.Add(new KeyValuePair<string, string>("Twilio-Sandbox-Mode", TwilioSandboxMode));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Update a specific Factor. This endpoint can be used to Verify a Factor if passed an `AuthPayload` param.
    /// </summary>
    public class UpdateFactorOptions : IOptions<FactorResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique external identifier of the Entity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// A string that uniquely identifies this Factor.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// Optional payload to verify the Factor for the first time
        /// </summary>
        public string AuthPayload { get; set; }
        /// <summary>
        /// The friendly name of this Factor
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The config for this Factor as a json string
        /// </summary>
        public string Config { get; set; }
        /// <summary>
        /// The Twilio-Sandbox-Mode HTTP request header
        /// </summary>
        public string TwilioSandboxMode { get; set; }

        /// <summary>
        /// Construct a new UpdateFactorOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Factor. </param>
        public UpdateFactorOptions(string pathServiceSid, string pathIdentity, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AuthPayload != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthPayload", AuthPayload));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Config != null)
            {
                p.Add(new KeyValuePair<string, string>("Config", Config));
            }

            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (TwilioSandboxMode != null)
            {
                p.Add(new KeyValuePair<string, string>("Twilio-Sandbox-Mode", TwilioSandboxMode));
            }

            return p;
        }
    }

}