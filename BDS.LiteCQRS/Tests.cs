using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDS.LiteCQRS.Impl;
using MediatR;
using Microsoft.Practices.ServiceLocation;
using Xunit;

namespace BDS.LiteCQRS
{
    public class Tests
    {
        public Tests()
        {
            Bootstrapper.Bootstrap();
        }

        [Fact]
        public void ShouldResolve()
        {
            var handler = ServiceLocator.Current.GetInstance<IAsyncRequestHandler<CreateAccountCommand, int>>();

            var mediator = ServiceLocator.Current.GetInstance<IMediator>();
            var asyncResponse = mediator.SendAsync(new CreateAccountCommand());
            Assert.Equal(5, asyncResponse.Result);
        }
    }
}
