using SampleApp.Services.EF;
using SampleApp.Utilities.SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services.Services
{
    public abstract class ServiceBase
    {
        private AdventureWorks2017Entities _adventureWorksEntities;

        protected AdventureWorks2017Entities AdventrueWorksEntites
        {
            get
            {
                if (_adventureWorksEntities == null)
                    _adventureWorksEntities = SimpleInjectorAccessor.Container.GetInstance<AdventureWorks2017Entities>();

                return _adventureWorksEntities;
            }
        }
    }
}
