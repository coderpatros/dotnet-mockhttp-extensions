using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Xunit;
using CoderPatros.MockHttpExtensions.Matchers;

namespace CoderPatros.MockHttpExtensions.Tests.ContentTypeMatcherTests
{
    public class ContentTypeMatcherTests
    {
        [Fact]
        public void TestMatchesWithCorrectContentTypeIsTrue()
        {
            var matcher = new ContentTypeMatcher("application/json");
            var message = new HttpRequestMessage();
            message.Content = new ByteArrayContent(Encoding.UTF8.GetBytes("true"));
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            Assert.True(matcher.Matches(message));
        }

        [Fact]
        public void TestMatchesWithIncorrectContentTypeIsFalse()
        {
            var matcher = new ContentTypeMatcher("application/json");
            var message = new HttpRequestMessage();
            message.Content = new ByteArrayContent(Encoding.UTF8.GetBytes("true"));
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");

            Assert.False(matcher.Matches(message));
        }

        [Fact]
        public void TestMatchesWithPartialCorrectContentTypeIsTrue()
        {
            var matcher = new ContentTypeMatcher("text/plain");
            var message = new HttpRequestMessage();
            message.Content = new ByteArrayContent(Encoding.UTF8.GetBytes("true"));
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain")
            {
                CharSet = "utf-8"
            };

            Assert.True(matcher.Matches(message));
        }

        [Fact]
        public void TestMatchesWithFullCorrectContentTypeIsTrue()
        {
            var matcher = new ContentTypeMatcher("text/plain; charset=utf-8");
            var message = new HttpRequestMessage();
            message.Content = new ByteArrayContent(Encoding.UTF8.GetBytes("true"));
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain")
            {
                CharSet = "utf-8"
            };

            Assert.True(matcher.Matches(message));
        }

        [Fact]
        public void TestMatchesWithIncorrectCharSetIsFalse()
        {
            var matcher = new ContentTypeMatcher("text/plain; charset=utf-8");
            var message = new HttpRequestMessage();
            message.Content = new ByteArrayContent(Encoding.UTF32.GetBytes("true"));
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain")
            {
                CharSet = "utf-32"
            };

            Assert.False(matcher.Matches(message));
        }
    }
}
