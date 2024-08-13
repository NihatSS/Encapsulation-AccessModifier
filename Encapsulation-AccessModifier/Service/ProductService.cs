using Encapsulation_AccessModifier.Data;
using Encapsulation_AccessModifier.Model;

namespace Encapsulation_AccessModifier.Service
{
    internal class ProductService
    {
        AppDBContext context;
        public ProductService()
        {
            context = new AppDBContext();
        }

        public Product[] GetAll()
        {
            return context.GetProducts();
        } 

        public Product GetById(int id)
        {
            var response = context.GetProducts();
            return Array.Find(response, m=> m.Id == id);
        }
    }
}
