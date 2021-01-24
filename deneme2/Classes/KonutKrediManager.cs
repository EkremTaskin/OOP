using System;
using System.Collections.Generic;
using System.Text;
using deneme2.Interfaces;

namespace deneme2.Classes
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Hesaplandı");
        }
    }
}
