﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            
            krediManager.Hesapla();

        }
        public void KrediOnBilgilendirmesiYap()
        {

        }
    }
}
