using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services.Interfaces
{
    public interface IProductService
    {
        Core.Models.Product GetProductById(int id);
    }
}
