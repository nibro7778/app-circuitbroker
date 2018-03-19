

using System.Net.Http;

namespace Services
{
    public class HttpClientFactory : IHttpClientFactory
    {
        private HttpClient _httpClient;

        public HttpClient GetHttpClient()
        {
            if (_httpClient == null)
            {
                var httpClientHandler = new HttpClientHandler
                {
                    UseDefaultCredentials = true,
                    ClientCertificateOptions = ClientCertificateOption.Automatic,
                    PreAuthenticate = true,
                    AllowAutoRedirect = true
                };
                _httpClient = System.Net.Http.HttpClientFactory.Create(httpClientHandler);
            }
            return _httpClient;
        }
    }
}
