using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BDS.LiteCQRS.Impl
{
    public class CreateAccountHandler : IAsyncRequestHandler<CreateAccountCommand, int> //IBaseHandler<CreateAccountCommand, int>
    {
        public Task<int> Handle(CreateAccountCommand message)
        {
            return Task.FromResult(5);
        }
    }
}
