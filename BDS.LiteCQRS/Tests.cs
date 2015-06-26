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
            var mediator = ServiceLocator.Current.GetInstance<IMediator>();
            var response = mediator.Send(new CreateAccountCommand());
            Assert.Equal(5, response);
        }
    }
}
