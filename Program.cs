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
            VykonajFind();
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
        
        //ARRAYS Skupinka
        else if (prikaz.ToLower() == "array")
        {
            VykonajArray();
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

        Console.Write("odmocnina z čísla " + odmcislo1 + " sa rovná " + Math.Sqrt(odmcislo1));
    }

    //FIND
    static void VykonajFind()
    {
        Console.WriteLine("Rozkaz = find. Hľadáme podreťazec vo vete");
        
        Console.Write("Zadaj celú vetu: ");
        string veta = Console.ReadLine();
        
        Console.Write("Zadaj, čo mám vo vete nájsť: ");
        string hladaneSlovo = Console.ReadLine();
            
        int pozicia = veta.IndexOf(hladaneSlovo);

        if (pozicia != -1)
        {
            Console.WriteLine("Slovo " + hladaneSlovo + "Sa nachádza na pozícii" + pozicia);
        }
        else
        {
            Console.WriteLine("Slovo " + hladaneSlovo +" sa vo vete nenachádza.");
        }
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
        else if (rectcislo1 <= 0)
        {
            Console.Write(rectcislo1 + " Nemôže byť záporné");
        }
        else if (rectcislo2 <= 0)
        {
            Console.Write(rectcislo2 + " Nemôže byť záporné");
        }
        else
        {
            while (true)
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
                else if (rectprikaz.ToLower() == "diagonal")
                {
                    double DiagonalVysledok = Math.Sqrt(Math.Pow(rectcislo1, 2) + Math.Pow(rectcislo2, 2));
                    Console.Write("Uhlopriečka Obdĺžnika je " + DiagonalVysledok);
                }


                else if (rectprikaz == "exit")
                {
                    Console.WriteLine("Ukončujem program Asistenta...");
                    Environment.Exit(0);
                }

                else
                {
                    Console.Write("Neznámy príkaz");
                }
            }
        }
    }
    //Array
    static void VykonajArray()
    {
        Console.WriteLine("Rozkaz = array. Pracujeme s obdĺžnikom");
        Console.Write("Napíš svoje pole: ");
        string vstup = Console.ReadLine();
        
        string[] rozdelenyText = vstup.Split(' ');
        
        int[] poleCisel = new int[rozdelenyText.Length];
        
        for (int i = 0; i < rozdelenyText.Length; i++)
        {
            poleCisel[i] = int.Parse(rozdelenyText[i]);
        }
        
        while (true)
        {
            Console.Write("Čo chceš robiť so svojim poľom? ");
            string arrayprikaz = Console.ReadLine().ToLower();

           //Find
            if (arrayprikaz.ToLower() == "find")
            {
                Console.Write("Aké číslo chceš nájsť?");
                int hladaneCislo = int.Parse(Console.ReadLine());
                
                int pozicia = -1;
                
                for (int i = 0; i < poleCisel.Length; i++)
                {
                    if (poleCisel[i] == hladaneCislo)
                    {
                        pozicia = i;
                        break;
                    }
                }

                if (pozicia != -1)
                {
                    
                    Console.Write("Číslo " + hladaneCislo + " sa v poli nachádza na pozícii " + (pozicia + 1));
                }
                else
                {
                    Console.Write("Číslo " + hladaneCislo + " sa v poli nenachádza");
                }
            }
            
            //Min
            else if (arrayprikaz.ToLower() == "min")
            {
                int minCislo = poleCisel[0]; 
                
                for (int i = 1; i < poleCisel.Length; i++)
                {
                    if (poleCisel[i] < minCislo)
                    {
                        minCislo = poleCisel[i]; 
                    }
                }
                Console.WriteLine("Namenšie číslo v poli je : " + minCislo);
            }
            
            //Sort
            else if (arrayprikaz.ToLower() == "sort")
            {
                for (int i = 0; i < poleCisel.Length; i++)
                {
                    for (int j = i + 1; j < poleCisel.Length; j++)
                    {
                        if (poleCisel[i] > poleCisel[j])
                        {
                            int pomocnaPremenna = poleCisel[i];
                            poleCisel[i] = poleCisel[j];
                            poleCisel[j] = pomocnaPremenna;
                        }
                    }
                }
                
                Console.Write("Zoradil som pole od najmenšieho, po najväčšie hodnoty: ");
                for (int i = 0; i < poleCisel.Length; i++)
                {
                    Console.Write(poleCisel[i] + " ");
                }
                Console.WriteLine();
            }
            
            else if (arrayprikaz.ToLower() == "exit")
            {
                Console.WriteLine("Ukončujem program Asistenta...");
                Environment.Exit(0);
            }
            
            else
            {
                Console.Write("Neznámy príkaz");
            }
        }
    }
}