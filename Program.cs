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
            VykonajSum();
        }
        
        //príkaz odm kde odmocnujem (2)
        else if (prikaz.ToLower() == "odm")
        {
           VykonajOdm();
        }
        
        //príkaz find kde hľadám podreťazce vo vetách (3)
        else if (prikaz.ToLower() == "find")
        {
            Console.WriteLine("Rozkaz = find. Pracujeme s Operáciou hladanie podreťazca vo vete");
            
            Console.Write("Zadaj vetu: ");
            string Veta = Console.ReadLine();
            
            Console.Write("Zadaj slovo ktoré hľadáš: ");
            string slovo_do_vety = Console.ReadLine();

            if (Veta.Contains(slovo_do_vety))
            {
                
            }
            else
            {
                Console.Write("slovo sa nenachádza vo vete.");
            }
        }
        
          
        //Príkaz rect, kde riešime Obdĺžniky
        else if (prikaz.ToLower() == "rect")
        {
            VykonajRect();
        }    


        //HELP! HELP ME!
        else if (prikaz.ToLower() == "help")
        {
          VykonajHelp();
        }
      
        else
        {
            Console.WriteLine("Ups! nezadal si správny príkaz!");
        }
        
        

    }
    
    
    //Funkcia pre SUM
    static void VykonajSum()
    {
        Console.WriteLine("Rozkaz = sum. Pracujeme s Operáciou sčítania");
            
        Console.Write("Zadaj prvé číslo: ");
        int sumcislo1 = int.Parse(Console.ReadLine());
        Console.Write("Zadaj druhé číslo: ");
        int sumcislo2 = int.Parse(Console.ReadLine());
            
        int sumvysledok = sumcislo1 + sumcislo2;
        Console.Write(sumcislo1 + " + " + sumcislo2 + " sa rovná " + sumvysledok);
    }
    //ODM
    static void VykonajOdm()
    {
        Console.WriteLine("Rozkaz = odm. Pracujeme s Operáciou odmocnovania");
            
        Console.Write("Zadaj číslo na odmocnenie: ");
        int odmcislo1 = int.Parse(Console.ReadLine());

        Console.Write("odmocnina z čísla " + odmcislo1 + " sa rovná " +Math.Sqrt(odmcislo1));
    }
    //HELP
    static void VykonajHelp()
    {
        Console.WriteLine("Potrebuješ pomoc? ok. Tu máš príkazy a čo robia: ");
        Console.WriteLine("sum - sčítanie dvoch (stačí celých) čísel");
        Console.WriteLine("odm - odmocnina zo zadaného čísla");
        Console.WriteLine("find - nájde podreťazec vo vete");
    }
    //RECT
    static void VykonajRect()
    {
        Console.WriteLine("Rozkaz = rect. Pracujeme s obdĺžnikom");
        //dĺžky
        Console.Write("Zadaj prvú dĺžku: ");
        int rectcislo1 = int.Parse(Console.ReadLine());
        
        Console.Write("Zadaj druhú dĺžku: ");
        int rectcislo2 = int.Parse(Console.ReadLine());
        
        if (rectcislo1 == rectcislo2)
        {
            Console.Write("čísla sa nemôžu rovnať");
        }
        else if (rectcislo1 > 0)
        {
            Console.Write(rectcislo2 + " Nemôže byť záporné");
        }
        else if (rectcislo2 > 0)
        {
            Console.Write(rectcislo1 + " Nemôže byť záporné");
        }
        else
        {
            Console.WriteLine("Máme obdĺžnik s dĺžkalmi " + rectcislo1 + " a " + rectcislo2);
            Console.WriteLine("Ako chceš merať obdĺžnik?");
            Console.Write("area, perimeter alebo diagonal?: ");
            //area
            string rectprikaz = Console.ReadLine();
            if (rectprikaz.ToLower() == "area")
            {
                int areaVysledok = rectcislo1 * rectcislo2;
                Console.Write("obsah obdĺžnika je " + areaVysledok);
            }
            //perimeter
            else if (rectprikaz.ToLower() == "perimeter")
            {
                int perimeterVysledok = rectcislo1 + rectcislo2 + rectcislo1 + rectcislo2;
                Console.Write("obsah obvod je " + perimeterVysledok);
            }
            //diagonal
            
            
        }
    }
}
