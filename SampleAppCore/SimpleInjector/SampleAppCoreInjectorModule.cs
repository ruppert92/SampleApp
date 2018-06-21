using Microsoft.Extensions.Configuration;
using SampleAppCore.Business.SimpleInjector;
using SampleAppCore.Utilities.SimpleInjector;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SampleAppCore.SimpleInjector
{
    public static class SampleAppCoreInjectorModule
    {
        public static void LoadTypes(Container container)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            container.Register<IConfiguration>(() => configuration);

            SimpleInjectorAccessor.Load(SampleAppCoreBusinessInjectorModule.LoadTypes);
        }
    }
}
