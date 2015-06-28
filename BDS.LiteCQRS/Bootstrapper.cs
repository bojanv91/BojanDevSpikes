using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDS.LiteCQRS.Impl;
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

                    scanner.AddAllTypesOf(typeof(IAsyncRequestHandler<,>));
                });

                //cfg.For(typeof(IAsyncRequestHandler<,>))
                //    .DecorateAllWith(typeof(ValidatorHandler<,>));

                cfg.For<IMediator>().Use<Mediator>().Singleton();

                cfg.For<Microsoft.Practices.ServiceLocation.ServiceLocatorProvider>()
                    .Use(serviceLocationProvider)
                    .Singleton();
            });

            Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(serviceLocationProvider);

            string whatdoihave = _container.WhatDoIHave();
        }
    }
}
