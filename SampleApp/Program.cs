using SampleApp.Services.Interfaces;
using SampleApp.SimpleInjector;
using SampleApp.Utilities.SimpleInjector;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace SampleApp
{
    class Program
    {
        class FileData
        {
            public int FileId { get; set; }
            public int RowNum { get; set; }
            public int ColNum { get; set; }
            public string Value { get; set; }
        }
        static void Main(string[] args)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            SimpleInjectorAccessor.RegisterContainer(container);
            SimpleInjectorAccessor.Load(SampleAppInjectorModule.LoadTypes);

            //List<FileData> fileDatas = new List<FileData>();
            //using (TextFieldParser csvReader = new TextFieldParser("path"))
            //{
            //    csvReader.SetDelimiters(new string[] { "," });
            //    csvReader.HasFieldsEnclosedInQuotes = true;
            //    int row = 1;
            //    while (!csvReader.EndOfData)
            //    {
            //        string[] fieldData = csvReader.ReadFields();
            //        // Code to build an entry or perform other actions goes here
            //        for(int col = 0; col < fieldData.Length; col++)
            //        {
            //            fileDatas.Add(new FileData()
            //            {
            //                FileId = 0,
            //                RowNum = row,
            //                ColNum = col,
            //                Value = fieldData[col]
            //            });
            //        }
            //        row++;
            //    }
            //}
            ////Bulk insert data from the list

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
