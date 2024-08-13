using Encapsulation_AccessModifier.Service;
using System.ComponentModel;

namespace Encapsulation_AccessModifier.Controller
{
    internal class ProductController
    {
        ProductService _service;
        public ProductController()
        {
            _service = new ProductService();
        }

        public void GetAll()
        {
            var products = _service.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product.Name+ "  |  "+ product.Quantity + "  |  " +product.Price);
            }
        }

        public void GetById()
        {
            Console.WriteLine("Add product id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(_service.GetById(id));
        }
    }
}
