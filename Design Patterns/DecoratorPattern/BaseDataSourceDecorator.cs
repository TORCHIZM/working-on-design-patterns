using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator
{
    // UML diyagramındaki Component (IDataSource) arayüzünü uygular.
    // Constructor sayesinde özellikleri değiştirilmesi istenen nesnenin referansı tutulur.
    // Değiştirilmesini istedğimiz metotları abstract anahtar kelimesi ile işaretledik.
    // UML diyagramındaki BaseDecorator yapısına denk gelmektedir.
    abstract class BaseDataSourceDecorator : IDataSource
    {
        protected IDataSource dataSource;

        public BaseDataSourceDecorator(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public abstract string GetFileName();
        public abstract void ReadData();
        public abstract void WriteData(object data);
    }
}
