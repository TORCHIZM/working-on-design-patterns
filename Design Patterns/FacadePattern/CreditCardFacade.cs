using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FacadePattern
{
    class CreditCardFacade
    {
        public void CreateCreditCard(Customer customer)
        {
            CreditCardManager creditCardManager = new CreditCardManager();
            BlackListService blackListService = new BlackListService();

            if (blackListService.CheckEmployeeIsTheBlackList(customer))
                creditCardManager.CreateCreditCart(customer);
        }
    }
}
