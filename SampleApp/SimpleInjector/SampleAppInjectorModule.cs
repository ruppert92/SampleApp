using SampleApp.Services.SimpleInjector;
using SampleApp.Utilities.SimpleInjector;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.SimpleInjector
{
    public static class SampleAppInjectorModule
    {
        public static void LoadTypes(Container container)
        {
            SimpleInjectorAccessor.Load(SampleAppServicesInjectorModule.LoadTypes);            
        }
    }
}
