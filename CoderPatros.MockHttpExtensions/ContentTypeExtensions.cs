using System;
using System.Diagnostics.Contracts;
using RichardSzalay.MockHttp;
using CoderPatros.MockHttpExtensions.Matchers;

namespace CoderPatros.MockHttpExtensions
{
    public static class ContentTypeExtensions
    {
        public static MockedRequest WithContent(
            this MockedRequest handler,
            string contentType,
            string content)
        {
            Contract.Requires(handler != null);
            Contract.Requires(!string.IsNullOrEmpty(contentType));
            Contract.Requires(!string.IsNullOrEmpty(content));

            handler.WithContent(content);
            handler.With(new ContentTypeMatcher(contentType));

            return handler;
        }
    }
}
