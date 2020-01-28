using System;
using System.Text.Json;
using RichardSzalay.MockHttp;
using CoderPatros.MockHttpExtensions.ContentTypeExtensions;

namespace CoderPatros.MockHttpExtensions.JsonExtensions
{
    public static class JsonExtensions
    {
        public static MockedRequest WithJsonContent(this MockedRequest handler, string json)
        {
            handler.WithContent("application/json", json);
            return handler;
        }

        public static MockedRequest WithJsonSerializedContent(this MockedRequest handler, object obj)
        {
            handler.WithContent("application/json", JsonSerializer.Serialize(obj));
            return handler;
        }
    }
}
