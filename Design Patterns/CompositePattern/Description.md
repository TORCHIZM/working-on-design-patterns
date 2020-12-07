Composite tasarım deseni, nesneleri ağaç yapısına göre düzenleyerek ağaç yapısındaki
alt üst ilişkisini kurmaya yarayan bir desendir.

Bu tasarım deseninin amacının nesneleri ağaç yapısına göre düzenleyerek,
ağaç yapısındaki alt üst ilişkisini kurmak olduğunu soyledik. Burada ağacın
herbir yapısı ortak bir arayüzü uygular. Ortak arayüzü uygulamasının sebebi
ise birbirine benzer yapılar ile çalışıyor olmak bu benzerlik bizlere esnek bir yapı sunacaktır.

Aşağıdaki bu desene ait UML diyagramı yer almaktadır.

![Composite-Pattern](https://raw.githubusercontent.com/TORCHIZM/tasarim-desenleri-turkce-kaynak/master/images/composite-uml.png)

Client: İstemci sınıf.

Component: Soyut yapımızdır, özellikler içerisinde tanımlıdır ve diğer sınıflar bu yapıyı uygular.

Composite: Alt öğeleri olan sınıfımızdır, Compoent'in somut halidir ve
içerisinde Component listesi tutmaktadır.

Leaf: Ağaç yapısındaki en alt elemanı temsil etmektedir.

Senaryo olarak iç içe geçmiş kategorileri ve kategorilerin en altında bulunan ürünleri düşünebiliriz.