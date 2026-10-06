using System.Runtime.InteropServices.JavaScript;

namespace akokoľvek_chcete;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("Zadaj Príkaz: ");
        string prikaz = Console.ReadLine();
        
        //príkaz sum kde sčítavam (1)
        if (prikaz.ToLower() == "sum")
        {
            Console.WriteLine("Rozkaz = sum. Pracujeme s Operáciou sčítania");
            
            Console.Write("Zadaj prvé číslo: ");
            int sumcislo1 = int.Parse(Console.ReadLine());
            Console.Write("Zadaj druhé číslo: ");
            int sumcislo2 = int.Parse(Console.ReadLine());

            int sumvysledok = sumcislo1 + sumcislo2;
            Console.Write(sumcislo1 + " + " + sumcislo2 + " sa rovná " + sumvysledok);
        }
        
        //príkaz odm kde odmocnujem (2)
        else if (prikaz.ToLower() == "odm")
        {
            Console.WriteLine("Rozkaz = odm. Pracujeme s Operáciou odmocnovania");
            
            Console.Write("Zadaj číslo na odmocnenie : ");
            int odmcislo1 = int.Parse(Console.ReadLine());

            Console.Write("odmocnina z čísla " + odmcislo1 + " sa rovná " +Math.Sqrt(odmcislo1));
        }
        
        //príkaz find kde hľadám podreťazce vo vetách (3)
        else if (prikaz.ToLower() == "find")
        {
            Console.WriteLine("Rozkaz = find. Pracujeme s Operáciou hladanie podreťazca vo vete");
        }
        
        //HELP! HELP ME!
        else if (prikaz.ToLower() == "help")
        {
            Console.WriteLine("Potrebuješ pomoc? ok. Tu máš príkazy a čo robia: ");
            Console.WriteLine("sum - sčítanie dvoch (stačí celých) čísel");
            Console.WriteLine("odm - odmocnina zo zadaného čísla");
            Console.WriteLine("find - nájde podreťazec vo vete");
        }
        
        else
        {
            Console.WriteLine("Ups! nezadal si správny príkaz!");
        }
    }
}

