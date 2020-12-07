using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CompositePattern
{
    public static class RunIt
    {
        public static void Run()
        {
            ProductCatalog items = new ProductCatalog("Ürünler");
            ProductCatalog phones = new ProductCatalog("Telefonlar");

            ProductCatalog iPhone = new ProductCatalog("iPhone Telefonlar");
            ProductCatalog Samsung = new ProductCatalog("Samsung Telefonlar");

            Product iphone5Item = new Product("iPhone 5 Telefon");
            Product samsungGalaxyItem = new Product("Samsung Galaxy Telefon");

            // En üst hiyerarşiye telefon düğümü ekleniyor.
            items.Add(phones);

            // Telefon hiyerarşisine Samsung ve iPhone düğümleri ekleniyor.
            phones.Add(iPhone);
            phones.Add(Samsung);

            // iPhone hiyerarşisine iPhone 5 yaprağı (En alt yapıdır, içerisinde bir düğüm içermez) ekleniyor.
            iPhone.Add(iphone5Item);
            //Samsung hiyerarşisine Samsung Galaxy yaprağı (En alt yapıdır, içerisinde bir düğüm içermez) ekleniyor.
            Samsung.Add(samsungGalaxyItem);

            items.DrawHierarchy();

            //output:
            //  -Ürünler
            //  --Telefonlar
            //  ---iPhone Telefonlar
            //  ----iPhone 5 Telefon
            //  ---Samsung Telefonlar
            //  ----Samsung Galaxy Telefon
        }
    }
}
