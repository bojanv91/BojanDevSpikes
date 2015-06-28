using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BDS.LiteCQRS.Impl
{
    public class ValidatorHandler<TRequest, TResponse> : IAsyncRequestHandler<TRequest, TResponse>
        where TRequest : IAsyncRequest<TResponse>
    {
        private readonly IAsyncRequestHandler<TRequest, TResponse> _inner;

        public ValidatorHandler(IAsyncRequestHandler<TRequest, TResponse> inner)
        {
            _inner = inner;
        }

        public Task<TResponse> Handle(TRequest message)
        {
            return _inner.Handle(message);
        }
    }
}
