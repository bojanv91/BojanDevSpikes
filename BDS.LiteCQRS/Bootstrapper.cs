using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Practices.ServiceLocation;
using StructureMap;
using StructureMap.Graph;

namespace BDS.LiteCQRS
{
    public static class Bootstrapper
    {
        public static void Bootstrap()
        {
            var _container = new Container();

            var serviceLocationResolver = new StructureMapServiceLocator(_container);
            var serviceLocationProvider = new ServiceLocatorProvider(() => serviceLocationResolver);

            _container.Configure(cfg =>
            {
                cfg.Scan(scanner =>
                {
                    scanner.TheCallingAssembly();
                    scanner.WithDefaultConventions();

                    scanner.AddAllTypesOf(typeof(IRequestHandler<,>));
                });

                cfg.For<Microsoft.Practices.ServiceLocation.ServiceLocatorProvider>()
                    .Use(serviceLocationProvider)
                    .Singleton();

                cfg.For<IMediator>().Use<Mediator>().Singleton();

                //var handlerType = cfg.For(typeof(IRequestHandler<,>));
                //handlerType.DecorateAllWith(typeof(ValidatorHandler<,>));
            });

            Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(serviceLocationProvider);
        }
    }
}
