using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.PrototypePattern
{
    public static class RunIt
    {
        public static void Run()
        {
            Employee ismail = new Employee("İsmail", "KOÇ");
            Employee cloneIsmail = ismail.Clone();

            // Aynı nesne örneklerini farklı referanslarda tutuyor.
            // Birbirinin aynısı ve farklı referanslarda olan nesneler elde ettik.
            Console.WriteLine($"{ismail == cloneIsmail}"); //output: false
        }
    }
}
