using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taugazovata
{//Таугазова Т.А. 31ИС
    //класс Товар
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public Product(string nm, string descr)
        {
            Name = nm;
            Number = descr;
        }
        public void Show()
        {
            Console.WriteLine(
                 $"Название: {Name}, Количество - {Number}");
        }
        public int CompareTo(Product? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
