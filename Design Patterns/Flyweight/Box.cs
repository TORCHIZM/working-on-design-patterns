using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight
{
    // Nesnenin ortak özelliklerini tutan sınıftır.
    // UML diyagramındaki Flyweight yapısına denk gelmektedir.
    abstract class Box
    {
        // Intrinsic değerler.
        public int width;
        public int height;
        public BoxColor boxColor;

        public abstract void Draw(int locationX, int locationY);
    }
}
