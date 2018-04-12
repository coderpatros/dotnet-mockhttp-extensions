using System;
using RichardSzalay.MockHttp;
using Patros.MockHttpExtensions.Matchers;

namespace Patros.MockHttpExtensions.ContentTypeExtensions
{
    public static class ContentTypeExtensions
    {
        public static MockedRequest WithContent(
            this MockedRequest handler,
            string contentType,
            string content)
        {
            handler.WithContent(content);
            handler.With(new ContentTypeMatcher(contentType));

            return handler;
        }
    }
}
