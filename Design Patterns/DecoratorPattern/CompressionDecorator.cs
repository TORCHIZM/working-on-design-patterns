using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator
{
    // Yeni davranışların tanımlandığı sınıftır.
    // UML diyagramındaki BaseDecorator (BaseDataSourceDecorator) sınıfından türer.
    // UML diyagramındaki ConcreteDecorator sınıfına denk gelmektedir.
    class CompressionDecorator : BaseDataSourceDecorator
    {
        public CompressionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string GetFileName()
        {
            return base.dataSource.GetFileName();
        }

        public override void ReadData()
        {
            // Veriyi okurken referansını tuttuğumuz sınıfın kendi davranışını sergilemesini istiyoruz.
            base.dataSource.ReadData();
        }

        public override void WriteData(object data)
        {
            // Burada gelen veriye ait sıkıştırma işlemleri yapılacaktır.
            Console.WriteLine("Data compressed.");

            // Sıkıştırma şlemleri yapıldıktan sonra yazma işlemleri gerçekleştirilir.
            Console.WriteLine($"Compressed data was written to {base.dataSource.GetFileName()}.");
        }
    }
}
