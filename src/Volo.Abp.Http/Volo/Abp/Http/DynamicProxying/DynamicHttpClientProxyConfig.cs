using System;

namespace Volo.Abp.Http.DynamicProxying
{
    public class DynamicHttpClientProxyConfig
    {
        public Type Type { get; }

        public string BaseUrl { get; }

        public DynamicHttpClientProxyConfig(Type type, string baseUrl)
        {
            Type = type;
            BaseUrl = baseUrl;
        }
    }
}