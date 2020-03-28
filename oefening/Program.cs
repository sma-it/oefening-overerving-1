using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Utils.Menu();


            // voeg oefeningen to door een callback naar een functie
            menu.AddOption('1', "Voer Oef1 uit", Oef.TestOef1);
            menu.AddOption('2', "Voer Oef2 uit", Oef.TestOef2);
            menu.AddOption('3', "Voer Oef3 uit", Oef.TestOef3);

            menu.Start();
        }
    }
}
