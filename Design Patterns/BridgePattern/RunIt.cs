using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BridgePattern
{
    public static class RunIt
    {
        public static void Run()
        {
            IMessageSender textMessageSender = new TextMessageSender();
            Message textMessage = new TextMessage(textMessageSender);
            textMessage.Send(); // output: TextMessageSender: Sending text message...

            IMessageSender emailMessageSender = new EmailMessageSender();
            Message emailMessage = new TextMessage(emailMessageSender);
            emailMessage.Send(); // output: EmailMessageSender: Sending email message...
        }
    }
}
