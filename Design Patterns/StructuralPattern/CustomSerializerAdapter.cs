using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPattern
{
    //Daha sonradan dahil edilen yapının sisteme adapte edilmesi işlemi.
    //Sistemin kullandığı arayüzü uygular.
    //Bu sayede IJsonSerializer'i uygulayan bir sınıf örneği istendiğinde bu sınıf örneğini vererek mevcut koda dokunmadan sistemin devam etmesi sağlanır.
    //UML diyagramındaki Adapter'a denk gelmektedir.
    class CustomSerializerAdapter : IJsonSerializer
    {
        public string SerializeObject(object obj)
        {
            CustomSerializer customSerializer = new CustomSerializer();
            return customSerializer.Serialize(obj);
        }
    }
}
