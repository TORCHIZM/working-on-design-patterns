using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.PrototypePattern
{
    //Klonlamak istediğimiz sınıflarımıza uygulayacağımız arayüz.
    //Farklı sınıflarda da kullanılması için Generic bir yapı oluşturuldu.
    //Generic yapı sayesinde dinami olarak tip odönüşümü sağlanacaktır.
    //Bu sayede farklı sınıflara da bu deseni uygulaama şansı doğuyor.
    interface IClonePrototype<TPrototype>
    {
        TPrototype Clone();
    }
}
