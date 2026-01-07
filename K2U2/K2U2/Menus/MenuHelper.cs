using System;
using System.Collections.Generic;
using System.Text;

namespace K2U2.Menus
{
    internal class MenuHelper
    {

        public void DisplayMainMenu()
        {
            PrintHeader("Library Management System");

            Console.WriteLine("1) Register New Book");
            Console.WriteLine("2) Register New Member");
            Console.WriteLine("3) Register Loan");
            Console.WriteLine("4) Register Return");
            Console.WriteLine("5) View Active Loans");
            Console.WriteLine("6) Search Books");
            Console.WriteLine("0) Exit");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("'database reset') RESET THE DATABASE");
            Console.ResetColor();
            Console.WriteLine("-------------------------------------------");
            Console.Write("Select an option: ");
        }


        // UI Utilities (STATIC METHODS)
        public static void PrintHeader(string title, ConsoleColor color = ConsoleColor.Cyan, int width = 50)
        {
            Console.Clear();
            Console.ForegroundColor = color;

            string border = new string('=', width);

            int padding = Math.Max(0, (width - title.Length) / 2);
            string centeredTitle = title.PadLeft(padding + title.Length).PadRight(width);

            Console.WriteLine(border);
            Console.WriteLine(centeredTitle.ToUpper());
            Console.WriteLine(border);

            Console.ResetColor();
        }
        public static void SuccessMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSUCCESS: {msg}");
            Console.ResetColor();
            Console.ReadKey();
        }

        public static void ErrorMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nERROR: {msg}");
            Console.ResetColor();
            Console.ReadKey();
        }

        
    }
}
