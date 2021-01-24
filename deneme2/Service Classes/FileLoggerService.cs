using System;
using System.Collections.Generic;
using System.Text;
using deneme2.Interfaces;

namespace deneme2.Service_Classes
{
    class FileLoggerService : IloggerService
    {
        public void log()
        {
            Console.WriteLine("File loglandı");
        }
    }
}
