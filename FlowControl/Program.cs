using System;

namespace FlowControl
{
    class Program
    {
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
            Console.Clear();
            Console.WriteLine("Huvudmeny. Skriv in siffror för att testa olika funktioner:");
            Console.WriteLine("0) Exit");
            Console.Write("\r\nTesta: ");

            switch (Console.ReadLine())
            {
                case "0":
                    //Exit application
                    return false;
                default:
                    _ = CaptureInput();
                    return true;
            }
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