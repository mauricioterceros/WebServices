using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class MySingleton
    {
        private static MySingleton _instance;

        public static MySingleton Instance
        {
            private set
            {
                _instance = value;
            }
            get
            {
                if (_instance == null)
                {
                    _instance = new MySingleton();
                }
                return _instance;
            }
        }

        private MySingleton()
        {
        }
        
        public List<Product> GetProducts()
        {
            return new List<Product>() { new Product() { Name = "Reloj" } , new Product() { Name = "TV" } };
        }
    }
}
