using SampleApp.Services.EF;
using SampleApp.Services.Interfaces;
using SampleApp.Services.Services;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services.SimpleInjector
{
    public static class SampleAppServicesInjectorModule
    {
        public static void LoadTypes(Container container)
        {
            container.Register<AdventureWorks2017Entities, AdventureWorks2017Entities>();

            container.Register<IProductService, ProductService>();
        }
    }
}
