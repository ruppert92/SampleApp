using SampleAppCore.Business.Data;
using SampleAppCore.Business.Interfaces;
using SampleAppCore.Business.Services;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAppCore.Business.SimpleInjector
{
    public static class SampleAppCoreBusinessInjectorModule
    {
        public static void LoadTypes(Container container)
        {
            container.Register<AdventureWorks2017Context>(() => new AdventureWorks2017Context());

            container.Register<IProductService, ProductService>();
        }
    }
}
