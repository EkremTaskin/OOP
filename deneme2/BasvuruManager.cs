using System;
using System.Collections.Generic;
using System.Text;
using deneme2.Interfaces;

namespace deneme2
{
    class BasvuruManager
    {
        public void Hesapla(List<IKrediManager> krediManager, List<IloggerService> logger)
        {
            foreach (var kredi in krediManager)
            {
                kredi.Hesapla();
            }
            foreach (var logs in logger)
            {
                logs.log();
            }
        }
    }
}
