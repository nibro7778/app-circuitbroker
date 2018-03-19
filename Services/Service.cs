
using System.Net.Http;
using System.Threading.Tasks;
using CircuitBreaker;

namespace Services
{
    public class Service : IService
    {
        private readonly ICircuitBreaker<HttpResponseMessage> _circuitBreaker;

        public Service(ICircuitBreaker<HttpResponseMessage> circuitBreaker)
        {
            _circuitBreaker = circuitBreaker;
        }

        public Task<HttpResponseMessage> GetHelloWorld()
        {
            throw new System.NotImplementedException();
        }

        public Task<HttpResponseMessage> PostHelloWorld()
        {
            throw new System.NotImplementedException();
        }
    }
}