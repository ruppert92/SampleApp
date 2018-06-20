using Microsoft.EntityFrameworkCore;
using SampleApp.Services.Data;
using SampleApp.Services.Interfaces;
using SampleApp.Services.Services;
using SimpleInjector;
using System.Configuration;

namespace SampleApp.Services.SimpleInjector
{
    public static class SampleAppServicesInjectorModule
    {
        public static void LoadTypes(Container container)
        {

            container.Register<AdventureWorks2017Context>(() => new AdventureWorks2017Context());

            container.Register<IProductService, ProductService>();
        }
    }
}
