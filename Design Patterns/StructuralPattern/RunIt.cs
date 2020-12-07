using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPattern
{
    public static class RunIt
    {
        public static void Run()
        {
            var customOperation = new CustomOperation(new CustomSerializerAdapter());

            string serializedObject = customOperation.SerializeObject(new object());

            Console.WriteLine(serializedObject);
        }
    }
}
