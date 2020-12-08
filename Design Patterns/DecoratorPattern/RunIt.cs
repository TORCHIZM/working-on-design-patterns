using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator
{
    public static class RunIt
    {
        public static void Run()
        {
            IDataSource dataSource = new FileDataSource("data.sql");
            IDataSource compressedDataSource = new CompressionDecorator(dataSource);

            compressedDataSource.ReadData();
            compressedDataSource.WriteData(new object());

            // output:
            //      data.sql readed.
            //      Data compressed.
            //      Compressed data was written to data.sql.
        }
    }
}
