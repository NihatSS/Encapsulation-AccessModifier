using Encapsulation_AccessModifier.Model;

namespace Encapsulation_AccessModifier.Data
{
    internal class AppDBContext
    {
        public Product[] GetProducts()
        {
            return new Product[]
            {
                new Product
                {
                    Id = 1,
                    Name = "Iphone 14 Pro Max",
                    Quantity = 15,
                    Price = 1000,
                },
                new Product
                {
                    Id = 2,
                    Name = "Iphone 15 Pro",
                    Quantity = 10,
                    Price = 1250,
                },
                new Product
                {
                    Id = 3,
                    Name = "Iphone 13 Pro Max",
                    Quantity = 20,
                    Price = 750,
                },
                new Product
                {
                    Id = 4,
                    Name = "Iphone 15 Pro Max",
                    Quantity = 7,
                    Price = 1500,
                },

            };
        }
    }
}
