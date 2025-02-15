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
using Twilio.Rest.Media.V1;

namespace Twilio.Tests.Rest.Media.V1
{

    [TestFixture]
    public class MediaRecordingTest : TwilioTest
    {
        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Media,
                "/v1/MediaRecordings/KVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                MediaRecordingResource.Delete("KVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = MediaRecordingResource.Delete("KVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Media,
                "/v1/MediaRecordings/KVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                MediaRecordingResource.Fetch("KVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"bitrate\": 1000,\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"duration\": 2147483647,\"format\": \"mp4\",\"links\": {\"media\": \"https://media.twilio.com/v1/MediaRecordings/KVcafebabecafebabecafebabecafebabe/Media\",\"timed_metadata\": \"https://media.twilio.com/v1/MediaRecordings/KVcafebabecafebabecafebabecafebabe/TimedMetadata\"},\"processor_sid\": \"ZXcafebabecafebabecafebabecafebabe\",\"resolution\": \"640x480\",\"source_sid\": \"RMcafebabecafebabecafebabecafebabe\",\"sid\": \"KVcafebabecafebabecafebabecafebabe\",\"media_size\": 2147483648,\"status\": \"completed\",\"status_callback\": \"https://www.example.com\",\"status_callback_method\": \"POST\",\"url\": \"https://media.twilio.com/v1/MediaRecordings/KVcafebabecafebabecafebabecafebabe\"}"
                                     ));

            var response = MediaRecordingResource.Fetch("KVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Media,
                "/v1/MediaRecordings",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                MediaRecordingResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 10,\"first_page_url\": \"https://media.twilio.com/v1/MediaRecordings?Status=processing&SourceSid=RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&ProcessorSid=ZXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&Order=asc&PageSize=10&Page=0\",\"previous_page_url\": null,\"url\": \"https://media.twilio.com/v1/MediaRecordings?Status=processing&SourceSid=RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&ProcessorSid=ZXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&Order=asc&PageSize=10&Page=0\",\"next_page_url\": null,\"key\": \"media_recordings\"},\"media_recordings\": []}"
                                     ));

            var response = MediaRecordingResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadItemsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 10,\"first_page_url\": \"https://media.twilio.com/v1/MediaRecordings?Status=completed&SourceSid=RMcafebabecafebabecafebabecafebabe&ProcessorSid=ZXcafebabecafebabecafebabecafebabe&Order=desc&PageSize=10&Page=0\",\"previous_page_url\": null,\"url\": \"https://media.twilio.com/v1/MediaRecordings?Status=completed&SourceSid=RMcafebabecafebabecafebabecafebabe&ProcessorSid=ZXcafebabecafebabecafebabecafebabe&Order=desc&PageSize=10&Page=0\",\"next_page_url\": null,\"key\": \"media_recordings\"},\"media_recordings\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"bitrate\": 1000,\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"duration\": 1000,\"format\": \"mp4\",\"links\": {\"media\": \"https://media.twilio.com/v1/MediaRecordings/KVcafebabecafebabecafebabecafebabe/Media\",\"timed_metadata\": \"https://media.twilio.com/v1/MediaRecordings/KVcafebabecafebabecafebabecafebabe/TimedMetadata\"},\"processor_sid\": \"ZXcafebabecafebabecafebabecafebabe\",\"resolution\": \"640x480\",\"source_sid\": \"RMcafebabecafebabecafebabecafebabe\",\"sid\": \"KVcafebabecafebabecafebabecafebabe\",\"media_size\": 1000,\"status\": \"completed\",\"status_callback\": \"https://www.example.com\",\"status_callback_method\": \"POST\",\"url\": \"https://media.twilio.com/v1/MediaRecordings/KVcafebabecafebabecafebabecafebabe\"}]}"
                                     ));

            var response = MediaRecordingResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}