using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAppCore.Business.Interfaces
{
    public interface IProductService
    {
        Core.Models.Product GetProductById(int id);
    }
}
