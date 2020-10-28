using System;
using HerosDB.Models;
using HerosDB;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu main = new MainMenu();
            main.Start();
        }

    }
}