using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BridgePattern
{
    // UML diyagramındaki ConcreteImplementor (EmailMessageSender) kısmına denk gelmektedir.
    // Implementor arayüzünü (IMessageSender) uygular.
    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("EmailmessageSender: Sending email message...");
        }
    }
}
