﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPuissance4
{
    class Program
    {
        static void Main(string[] args)
        {
            Puissance4 leJeuDeLaMortQuiTue = new Puissance4("leJeuDeLaMortQuiTue");
            leJeuDeLaMortQuiTue.Demarrer();
            Console.ReadKey();
        }
    }
}
