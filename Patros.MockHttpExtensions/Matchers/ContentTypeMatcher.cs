using System.Net.Http;
using RichardSzalay.MockHttp;

namespace Patros.MockHttpExtensions.Matchers
{
    public class ContentTypeMatcher : IMockedRequestMatcher
    {
        private readonly string _expectedContentType;

        public ContentTypeMatcher(string contentType)
        {
            _expectedContentType = contentType;
        }

        public bool Matches(HttpRequestMessage message)
        {
            var msgContentType = message.Content.Headers.ContentType.ToString();
            if (_expectedContentType.Contains(";"))
            {
                return msgContentType == _expectedContentType;
            }
            else
            {
                return msgContentType == _expectedContentType
                    || msgContentType.StartsWith(_expectedContentType + ";");
            }
        }
    }
}