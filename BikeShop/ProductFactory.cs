using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop
{
    public class ProductFactory
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IEnumerable<Product> FindProducts(string searchString)
        {
            return products.Where(p => p.Title.Contains(searchString));
        }

        #region In-memory Data

        static IList<Product> products;
        static ProductFactory()
        {
            products = new List<Product>();
            for (int i = 0 ; i < 100; i++)
            {
                products.Add(generateRandomProduct());
            }
        }

        static Random r = new Random(DateTime.Now.Millisecond);
        private static Product generateRandomProduct()
        {
            var titles = new string[] { "Classic city bike", "Vintage city bike", "Basic mountain bike", "Easy mountain bike", "Devil mountain bike" };
            var colors = new string[] { "Red", "Blue", "Green", "Brown", "Gray", "Black" };
            return new Product
            {
                Title = pickRandom(titles),
                Color = pickRandom(colors),
                Price = Math.Round(300M + (decimal)r.NextDouble() * 170M, 2),
                Reference = "BK" + r.Next(100000).ToString("d8")
            };
        }

        static T pickRandom<T>(T[] array)
        {
            return array[r.Next(array.Length)];
        }

        #endregion
    }
}
