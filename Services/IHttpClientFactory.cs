

using System.Net.Http;

namespace Services
{
    public interface IHttpClientFactory
    {
        HttpClient GetHttpClient();
    }
}
