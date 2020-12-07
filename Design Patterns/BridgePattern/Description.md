![Bridge-Old](https://raw.githubusercontent.com/TORCHIZM/tasarim-desenleri-turkce-kaynak/master/images/bridge-old.png)

Yukarıdaki tasarımı baktığımız zaman tasarımımız kalıtım üzerine kuruludur ve
doğası gereği bir dezavantajı da kapsüllemeyi kırmasıdır.

Bunun yanı sıra TextMessage ya da EmailMessage gibi yapılarda oluşacak herhangi bir
değişiklik TextMessageSender veya EmailMessageSender gibi sınıfları etkilemektedir.
Birbirinden bağımsız yapılar değil.

Tekrar kullanılabilirlik açısından da olumsuz bir yana sahiptir.
Mesaj gönderme işlemlerini başka bir projede kullanmak istediğimizde bu işlemleri
gerçekleştiren sınıfların türediği sınıfları da beraberinde götürmemiz gerekcektir.

Bridge tasarım deseni burada abstraction ve implementation kısmını ayırarak birbirinden
bağımsız geliştirilebilir yapılar elde etmemizi sağlar.

Aşağıda Bridge tasarım desenine ait diyagram görülmektedir.

![Bridge-New](https://raw.githubusercontent.com/TORCHIZM/tasarim-desenleri-turkce-kaynak/master/images/bridge-without-imp-and-abst.png)

Yukarıdaki desene bakarak özetleyecek olursak:

Abstraction (Message): Implementor (MessageSender) arayüzünü barındırır ve
bu arayüzü uygulayan sınıfların metotlarını çağırmak için kullanılır.

RefinedAbstraction (TextMessage, EmailMessage): Soyutlamayı uygulayan ya da
onlardan türeyen sınıflardır.

Implementor (MessageSender): İmplementasyonları gerçekleştiren sınıfların uyguladığı arayüzdür.
Abstract (Message) sınıf tarafından referansı tutulur.

ConcreteImplementor(TextMessageSender, EmailMessageSender): Implementor (MessageSender)
arayüzünu uygulayan, gerçek işi yapan sınıflardır.