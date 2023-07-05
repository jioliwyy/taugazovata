using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taugazova31is
{//Таугазова Т.А. 31ИС
    // класс - склад
    public class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products = new List<Product>();
        public Store(string nm, string ad)
        {
            Name = nm;
            Address = ad;
        }
        public void ShowAll()
        {
            Console.WriteLine($"Человек: имя - {Name}, адрес - {Address}");
            Console.WriteLine("Список товаров:");
            Product.Sort();
            foreach (Product product in Products) { product.Show(); }
        }

    }
}