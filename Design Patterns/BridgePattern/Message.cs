using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BridgePattern
{
    // UML diyagramındaki Abstraction kısmına denk gelmektedir.
    // Implementor (IMessageSender) arayüzünün referansını tutmaktadır.
    public abstract class Message
    {
        protected IMessageSender messageSender;

        public Message(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }

        public abstract void Send();
    }
}
