using System;
using RichardSzalay.MockHttp;
using CoderPatros.MockHttpExtensions.Matchers;

namespace CoderPatros.MockHttpExtensions.ContentTypeExtensions
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
