using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.PrototypePattern
{
    //Employee sınıfına klonlama yeteneği kazandırmak için tanımladığımız arayüzü uyguladık.

    class Employee : IClonePrototype<Employee>
    {
        string firstName;
        string lastName;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Employee Clone()
        {
            return base.MemberwiseClone() as Employee;
        }
    }
}
