using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhLooparDemo

{
    internal class App
    {

        

        public void Run()
        {


            //a. Får mata in två tal.
            //b.Skriv sedan till skärmen summan av de två talen.
            //c.Skriv sedan en fråga-Vill du fortsätta(J/ N)?.
            //d.Svarar användaren J återupprepas punkt a-c
            //e.Svarar användaren N avbryts programmet

            Console.WriteLine("Skriv in ett tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett till tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(tal1 + tal2);

            Console.WriteLine("Vill du fortsätta J/N");
            string let = Console.ReadLine();

            if (let == "P" || let == "N");
            {

            }

           


            //Skapa ett program där användaren får mata in två tal.
            //Låt sedan programmet skriva ut alla tal som finns mellan dessa två tal på skärmen.
            //Lös detta med en for-loop.
            //Lös detta med en while-loop.
            //Gör med if-satser så att man kan skriva in
            //tal1 > tal1 och vice versa.
            //Om tal2 > tal1 ska du lista alla tal baklänges tal1 = 10 tall2 = 4 9 8 7 6 5

            //tal1 = 1 tall2 = 4 2 3



            //Console.WriteLine("Mata in ett tal");
            //int tal1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Mata in ett till tal");
            //int tal2 = Convert.ToInt32(Console.ReadLine());



            //int i = 0;
            //while (i <= tal2)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = tal1; i < tal2+1; i++)
            //{
            //    Console.WriteLine(i);
            //}










            //int tal1 = Convert.ToInt32(Console.ReadLine() );
            //int tal2 = Convert.ToInt32(Console.ReadLine() );

            ////10 in tal1
            //for(int i = tal1; i <tal2; i++)

            //{
            //    Console.WriteLine();

            //}





            //// Skapa ett program som skriver ut talen 0-10 på skärmen.
            //// Lös detta med en for-loop.
            ////Lös detta med en while-loop.

            //for int i = 0; i<= 10; i++)
            //{

            //   Console.WriteLine(i);


            //}

            //int counter = 0;
            //while (counter <= 10)
            //{

            //    Console.WriteLine(counter3);
            //    counter3++;

            //}



















            //string namnet = "Stefan"; //sträng är en lista med bokstäver.  +
            //string l = "A"
            //char letter = "A"; // sträng kan växa medans char endast en bokstav

            //foreach(char c in namnet) // för varje karaktär C som finns i namnet varje bokstav är en karaktär
            //{
            //    Console.WriteLine(c);

            //}

            //while
            //{



            //    //Do while kommer köras minst 1 gång
            //   Console.WriteLine("1. Starta spelet");
            //   Console.WriteLine("2. Kolla highscore");
            //   Console.WriteLine("3. Avsluta");
            //   Console.WriteLine("Vad vill du göra");
            //   string sel = Console.ReadLine();
            //   if (sel == "1")
            //   {
            //    Console.WriteLine("Spelet startar");
            //    Console.WriteLine("... och slutar");

            //   }

            //   if (sel == "2") 
            //   {
            //    Console.WriteLine("Higscsore visas");
            //        Console.WriteLine("Klart");

            //   }
            //   if (sel == "3")
            //   {
            //    break; // för för evigt men om man väljer 3 så break
            //   }

            //}

            ////      int age = 12;
            ////      if (age>10)
            ////      {
            ////          Console.WriteLine("Hej");


            ////      }
            ////      Console.WriteLine();
            ////}
            //// age++ = +1
            //// age -- = -1


            ////int age = 12;
            ////age -= 10;


            //////int year = 99; // variabel(låda) lever endast i sitt kodblock{}
            ////int age = 12;
            ////age -= 10;


            ////int year 99;

            ////// Skriv ut alla heltal mellan 20222 och 1972 i bakvänd ordning
            ////for (int year = 2022; year >= 1972; year--) // Denna variabel lever bara i nästa scope{}
            ////{
            ////    Console.WriteLine(year);
            ////}

            ////for (int year = 1972; year >= 2022; year--)
            ////{
            ////    Console.WriteLine(year);
            ////}





        }
    }






}
