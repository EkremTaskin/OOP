using System;
using System.Collections.Generic;
using System.Text;
using deneme2.Interfaces;

namespace deneme2.Classes
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı");
        }
    }
}
