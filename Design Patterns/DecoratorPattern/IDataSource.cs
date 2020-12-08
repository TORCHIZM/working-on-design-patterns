using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator
{
    // Üst sınıfların uygulayacağı arayüzdür.
    // Ypılacak temel işlemler tanımlanmıştır.
    // UML diyagramındaki Component arayüzüne denk gelmektedir.
    interface IDataSource
    {
        string GetFileName();
        void WriteData(object data);
        void ReadData();
    }
}
