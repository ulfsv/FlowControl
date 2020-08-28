using System;
using System.Linq;

namespace FlowControl
{
    class Program
    {
        private static int price;
        private static object word;

        //Create a new instance of payroll
        //static CinemaGroup cinemagroup = new CinemaGroup();
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear(); // to ensure the menu will be printed onto a blank console screen
            Console.WriteLine("Huvudmeny. Skriv in siffror för att testa olika funktioner:");
            Console.WriteLine("0) Exit");
            Console.WriteLine("1) Få pris på Biobiljett (Ungdom eller pensionär)");
            Console.WriteLine("2) Få text repeterad 10ggr (Du kann vinna en biobiljett!)");
            Console.WriteLine("3) Ange en mening med minst 3 ord");
            Console.Write("\r\nVälj siffra från menyn: ");

            switch (Console.ReadLine())
            {
                case "0":
                    //Exit application
                    return false;
                case "1":
                    TicketType();
                    return true;
                case "2":
                    RepeatText();
                    return true;
                case "3":
                    GetWord();
                    return true;
                default:
                    return true;
            }
        }



        private static void TicketType()
        {
            Console.Write("Ange din ålder: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 64)
            {
                if (age < 20)
                {
                    price = 80;
                    //Console.WriteLine("Ungdomspris 80kr");
                    Console.WriteLine($"\r\nUngdomspris: {price} kr");
                    Console.WriteLine("Tryck Enter för Huvudmeny");
                    Console.ReadLine();
                }
                else
                {
                    price = 120;
                    Console.WriteLine($"\r\nStandardpris: {price} kr");
                    Console.WriteLine("Tryck Enter för Huvudmeny");
                    Console.ReadLine();
                }
            }
            else
            {
                if (age >= 64)
                {
                    price = 90;
                    Console.WriteLine($"\r\nPensionärspris: {price} kr");
                    Console.WriteLine("Tryck Enter för Huvudmeny");
                    Console.ReadLine();
                }
            }
        }
        private static void RepeatText()
        {
            Console.Write("Skriv in en text som vi repeterar 10 gånger: ");
            string s = Console.ReadLine();
            var result = s;

            for (int i = 1; i < 11; i++)
            {
                string v = i + ". " + result;
                //ut = v;
                //result = string.Join(",", v);
                Console.Write($"{v} ");
                

            }
            Console.WriteLine();
            Console.WriteLine("Tryck Enter för Huvudmeny");
            Console.ReadLine();

        }
        private static void GetWord()
        {
            Console.Write("Skriv in en mening på minst tre ord: ");
            string sentence = Console.ReadLine();
            word = sentence.Split(' ').Skip(2);
            Console.WriteLine(word);
            Console.Write("Tryck Enter för Huvudmeny");
            Console.ReadLine();
        }
        private static string CaptureInput()
        {
            Console.Write("Felaktig inmatning! (Enter för huvudmeny.)");
            return Console.ReadLine();
        }
        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nInput: {message}");
            Console.Write("Felaktig inmatning!");
            Console.Write("Tryck Enter för Huvudmeny");
            Console.ReadLine();
        }
    }
}