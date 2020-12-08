﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator
{
    // Temel işlemlerin tanımlandığı IDataSource arayüzünü uygulayan sınıftır.
    // UML diyagramındaki ConcreteComponent sınıfına denk gelmektedir.
    class FileDataSource : IDataSource
    {
        private string _fileName;

        public FileDataSource(string fileName)
        {
            _fileName = fileName;
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void ReadData()
        {
            Console.WriteLine($"{_fileName} readed.");
        }

        public void WriteData(object data)
        {
            Console.WriteLine($"data has written to {_fileName}");
        }
    }
}
