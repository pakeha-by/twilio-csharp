/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Verify.V2.Service.Entity.Challenge;

namespace Twilio.Tests.Rest.Verify.V2.Service.Entity.Challenge
{

    [TestFixture]
    public class NotificationTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Entities/identity/Challenges/YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Notifications",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                NotificationResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateWithTtlResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"NTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"challenge_sid\": \"YC03XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\",\"date_created\": \"2015-07-30T20:00:00Z\",\"priority\": \"high\",\"ttl\": 150}"
                                     ));

            var response = NotificationResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateWithoutTtlResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"NTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"challenge_sid\": \"YC03XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\",\"date_created\": \"2015-07-30T20:00:00Z\",\"priority\": \"high\",\"ttl\": 300}"
                                     ));

            var response = NotificationResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}