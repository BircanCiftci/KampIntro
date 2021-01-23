﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection // Birden fazla loglama yapmak istediğimde list kullanırız
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendir
            //
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
