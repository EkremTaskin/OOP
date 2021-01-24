using System;
using System.Collections.Generic;
using deneme2.Classes;
using deneme2.Interfaces;
using deneme2.Service_Classes;

namespace deneme2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IloggerService> loggerServices = new List<IloggerService> {new DatabaseLoggerService() , new FileLoggerService() };
            List<IKrediManager> krediManagers = new List<IKrediManager> {new  EsnafKrediManager(), new TaksitKrediManager()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Hesapla(krediManagers , loggerServices);

            Console.ReadLine();
        }
    }
}
