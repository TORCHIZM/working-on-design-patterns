using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPattern
{
    class CustomSerializer
    {
        //Sisteme daha sonradan dahil olan yapı.
        //Sistemin kullandığı arayüzü uygulamamaktadır.
        //UML diyagramindaki Adaptee'ye denk gelmektedir.
        public string Serialize(object obj)
        {
            //Gelen nesneyi serilize etmek için temel operasyonel işlemler..
            //DataMisalignedException sonradan da gerekli değerin geri döndürülmesi...
            return "serialized with CustomSerializer";
        }
    }
}
