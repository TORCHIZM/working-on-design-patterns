using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FacadePattern
{
    public static class RunIt
    {
        // İSTENMEYEN DURUM
        // Başka bir yerde kullanıcıya kredi kartı oluşturmak
        // İstediğimizde tekrar aynı sorguları yapmak zorunda kalacağız
        public static void RunOne()
        {
            // İstemci tarafından gerekli işlemlerin yapılması.
            Customer ismail = new Customer("İsmail", "KOÇ");

            CreditCardManager creditCardManager = new CreditCardManager();
            BlackListService blackListService = new BlackListService();

            // Eğer müşterimiz kara listede değilse kredi kartı oluştur
            if (!blackListService.CheckEmployeeIsTheBlackList(ismail))
                creditCardManager.CreateCreditCart(ismail);
        }

        // İSTENEN DURUM:
        // Başka bir yerde kullanıcıya kredi kartı oluşturmak
        // İstediğimizde yeni bir sorgu yazmadan kredi kartı şartlara göre
        // Oluşturulacak
        public static void RunTwo()
        {
            Customer ismail = new Customer("İsmail", "KOÇ");

            CreditCardFacade creditCardFacade = new CreditCardFacade();
            creditCardFacade.CreateCreditCard(ismail);
        }
    }
}
