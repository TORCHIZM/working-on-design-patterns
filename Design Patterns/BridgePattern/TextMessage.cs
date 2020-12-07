using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BridgePattern
{
    // UML diyagramındaki RefinedAbstraction kısmına denk gelmektedir.
    // Abstraction (Message) sınıfından türer.
    public class TextMessage : Message
    {
        public TextMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send()
        {
            messageSender.SendMessage(this);
        }
    }
}
