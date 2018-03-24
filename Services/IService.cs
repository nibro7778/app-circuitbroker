

using System.Net.Http;
using System.Threading.Tasks;

namespace Services
{
    public interface IService
    {
        Task<HttpResponseMessage> GetHelloWorldAsync();
        Task<HttpResponseMessage> PostHelloWorld();
    }
}
