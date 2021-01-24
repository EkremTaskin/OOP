using System;
using System.Collections.Generic;
using System.Text;
using deneme2.Interfaces;

namespace deneme2.Classes
{
    class EsnafKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredi hesaplandı");
        }
    }
}
