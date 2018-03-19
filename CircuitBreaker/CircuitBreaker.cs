using Polly;
using System;
using System.Net;
using System.Threading.Tasks;


namespace CircuitBreaker
{
    public class CircuitBreaker<T> : ICircuitBreaker<T>
    {
        private static string _url = string.Empty;
        private readonly Policy _policy;
        private readonly Policy _policyAsync;

        public CircuitBreaker()
        {
            _policy = Policy.Handle<WebException>()
                .CircuitBreaker(2, TimeSpan.FromSeconds(60), _onBreak, _onReset);

            _policyAsync = Policy.Handle<WebException>()
                .CircuitBreakerAsync(2, TimeSpan.FromSeconds(60));
        }

        private readonly Action<Exception, TimeSpan> _onBreak =
            (exception, timespan) =>
            {
                //TODO: Something on break
            };

        private readonly Action _onReset =
            () =>
            {
                //TODO: Something on break
            };

        public T Execute(Func<T> action, string url)
        {
            _url = url;
            return _policy.Execute(action);
        }

        public Task<T> ExecuteAsync(Func<Task<T>> action, string url)
        {
            _url = url;
            return _policyAsync.ExecuteAsync(action);
        }
    }
}
