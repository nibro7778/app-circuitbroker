using System;
using System.Threading.Tasks;

namespace CircuitBreaker
{
    public interface ICircuitBreaker<TResult>
    {
        TResult Execute(Func<TResult> action, string url);
        Task<TResult> ExecuteAsync(Func<Task<TResult>> action, string url);
    }
}
