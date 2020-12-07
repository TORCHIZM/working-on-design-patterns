using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CompositePattern
{
    class Product : ICatalogComponent
    {
        private string _name;

        public Product(string name)
        {
            _name = name;
        }

        public void DrawHierarchy()
        {
            Console.WriteLine(_name);
        }
    }
}
