using SampleApp.Services.Factories;
using SampleApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services.Services
{
    public class ProductService : ServiceBase, IProductService
    {
        public Core.Models.Product GetProductById(int id)
        {
            var result = AdventrueWorksEntites.Products.Find(id);

            return Factory.CreateProductDTO(result);
        }
    }
}
