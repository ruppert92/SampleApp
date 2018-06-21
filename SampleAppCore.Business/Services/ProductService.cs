using SampleAppCore.Business.Factories;
using SampleAppCore.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAppCore.Business.Services
{
    public class ProductService : ServiceBase, IProductService
    {
        public Core.Models.Product GetProductById(int id)
        {
            var result = AdventureWorksContext.Product.Find(id);

            return Factory.CreateProductDTO(result);
        }
    }
}
