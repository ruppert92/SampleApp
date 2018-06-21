using SampleAppCore.Business.Interfaces;
using SampleAppCore.SimpleInjector;
using SampleAppCore.Utilities.SimpleInjector;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;

namespace SampleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            SimpleInjectorAccessor.RegisterContainer(container);
            SimpleInjectorAccessor.Load(SampleAppCoreInjectorModule.LoadTypes);

            var productService = SimpleInjectorAccessor.Container.GetInstance<IProductService>();
            int id;
            string entry;
            do
            {
                Console.Write("Enter Product Id:  ");
                entry = Console.ReadLine();
                if (int.TryParse(entry, out id))
                {
                    var product = productService.GetProductById(id);

                    if (product != null)
                    {
                        Console.WriteLine($"Name: {product.Name}\nPrice: {product.ListPrice}");
                    }
                    else
                    {
                        Console.WriteLine("Product Not Found");
                    }
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            } while (entry != "quit");
        }
    }
}
