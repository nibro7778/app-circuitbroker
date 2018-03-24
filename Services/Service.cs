
using System.Net.Http;
using System.Threading.Tasks;
using CircuitBreaker;

namespace Services
{
    public class Service : BaseService, IService
    {
        private readonly ICircuitBreaker<HttpResponseMessage> _circuitBreaker;

        public Service(ICircuitBreaker<HttpResponseMessage> circuitBreaker, IHttpClientFactory httpClientFactory, string baseAddress) 
            : base(httpClientFactory,baseAddress)
        {
            _circuitBreaker = circuitBreaker;
        }

        public async Task<HttpResponseMessage> GetHelloWorldAsync()
        {
            const string uri = "HelloWorld/Get";
            var response = await _circuitBreaker.ExecuteAsync(() => GetExternalServiceAsync(uri), uri);
            return response;
        }

        public Task<HttpResponseMessage> PostHelloWorld()
        {
            throw new System.NotImplementedException();
        }
    }
}