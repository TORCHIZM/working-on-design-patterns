using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypePattern.RunIt.Run();
            StructuralPattern.RunIt.Run();
            BridgePattern.RunIt.Run();
            CompositePattern.RunIt.Run();

            Console.ReadKey();
        }
    }
}
