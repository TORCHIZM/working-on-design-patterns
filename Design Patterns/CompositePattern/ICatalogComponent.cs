using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CompositePattern
{
    // Soyut yapımızdır.
    // UML diyagramındaki Component kısmına denk gelmektedir.
    // Diğer istemci sınıflar bu yapıyı uygular.
    // Diğer sınıfların uygulayacağı hiyerarşiyi çizme metodunu içermektedir.
    public interface ICatalogComponent
    {
        void DrawHierarchy();
    }
}
