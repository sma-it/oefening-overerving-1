using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    /* Een luchtvaartmaatschappij wil info over haar vervoer van bagage en cargo bijhouden. 
     * Onder bagage verstaan we de valiezen van de reizigers, cargo zijn de containers van bedrijven die 
     * met het vrachtvervoer vervoerd worden.
     * 
     * Er is bepaald dat van de bagage van de reizigers een id, het gewicht en de voor- en achternaam van de passagier 
     * bijgehouden moet worden.
     * 
     * Van cargo wil men een id, het gewicht en de gevaarlijkheidsgraad (gebruik hiervoor een integer) opslaan.
     * 
     * I.v.m. transportkosten moet het volgende voorzien worden:
     * -> Bagage tot 23 kg is gratis. Indien de bagage meer weegt dan 23 kg, moet er voor EXTRA kilo's 1 euro per kilo betaald
     *      worden. Voorzie een functie die de transportkost berekent. Indien er geen extra kost is, geeft de functie 0 als
     *      resultaat.
     * -> Voor cargo voorzie je eveneens een functie die de transportkost berekent met de volgende formule:
     *      vervoerskost = (gewicht x 3,75) + (gevaarlijkheidsgraad * 2)
     * 
     * Alle gegevens van zowel bagage als cargo moeten op het scherm getoond kunnen worden d.m.v. een print-functie. Hierbij 
     * toon je ook telkens de transportkosten.
     * 
     * Bepaal welke klassen je nodig hebt om dit zo efficiënt mogelijk uit te werken.
     * Maak in de functie TestOef3() enkele Bagage-objecten en een Cargo-objecten en pas op elk object de print-functie toe.
     * Controleer voor de verschillende gewichten of de transportkost correct berekend wordt.
     */

    
    public partial class Oef
    {
        public static void TestOef3()
        {
            
        }
    }

}
