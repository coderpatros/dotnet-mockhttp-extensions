using System;
using System.Text.Json;
using RichardSzalay.MockHttp;

namespace CoderPatros.MockHttpExtensions
{
    public static class JsonExtensions
    {
        public static MockedRequest WithJsonContent(this MockedRequest handler, string content)
        {
            handler.WithContent("application/json", content);
            return handler;
        }

        public static MockedRequest WithJsonSerializedContent(this MockedRequest handler, object content)
        {
            handler.WithContent("application/json", JsonSerializer.Serialize(content));
            return handler;
        }
    }
}
