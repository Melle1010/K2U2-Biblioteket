using K2U2.SQL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace K2U2.Menus
{
    internal class Menu
    {
        public void Run()
        {
            bool isRunning = true;
            LibraryDbContext context = new LibraryDbContext();
            MenuHelper menuHelper = new MenuHelper();
            MenuService menuService = new MenuService();

            while (isRunning)
            {
                menuHelper.DisplayMainMenu();
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": menuService.AddBook(context); break;
                    case "2": menuService.AddMember(context); break;
                    case "3": menuService.CreateLoan(context); break;
                    case "4": menuService.ReturnBook(context); break;
                    case "5": menuService.ShowActiveLoans(context); break;
                    case "6": menuService.SearchBooks(context); break;
                    case "0": isRunning = false; Console.WriteLine("\nGoodbye!"); break;
                    case "database reset":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\nWARNING: This will delete ALL data. Type 'YES' to confirm: ");
                        string confirm = Console.ReadLine();
                        if (confirm == "YES")
                        {
                            menuService.ResetDatabase(context);
                        }
                        else
                        {
                            Console.WriteLine("Reset cancelled.");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        MenuHelper.ErrorMessage("Invalid");
                        break;
                }
            }
        }
    }
}
