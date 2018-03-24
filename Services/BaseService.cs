

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Services
{
    public abstract class BaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _baseAddress;

        protected BaseService(IHttpClientFactory httpClientFactory, string baseAddress)
        {
            _httpClientFactory = httpClientFactory;
            _baseAddress = baseAddress;
        }

        public async Task<HttpResponseMessage> GetExternalServiceAsync(string requestUri)
        {
            var request = GetRequest(requestUri, HttpMethod.Get);
            return await _httpClientFactory.GetHttpClient().SendAsync(request);
        }

        public async Task<HttpResponseMessage> PostExternalServiceAsync(string requestUri, object obj)
        {
            var jsonRequest = JsonConvert.SerializeObject(obj);
            var httpContent = new StringContent(jsonRequest);
            var request = GetRequest(requestUri, HttpMethod.Post, httpContent);
            return await _httpClientFactory.GetHttpClient().SendAsync(request);
        }

        private HttpRequestMessage GetRequest(string uri, HttpMethod httpMethod, HttpContent httpContent = null)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                RequestUri = new Uri($"{_baseAddress}/{uri}"),
                Method = httpMethod,
            };

            if (httpMethod == HttpMethod.Post && httpContent != null)
                httpRequestMessage.Content = httpContent;

            return httpRequestMessage;
        }
    }
}
