using K2U2.SQL.Context;
using K2U2.SQL.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace K2U2.Menus
{
    internal class MenuService
    {
        public void AddBook(LibraryDbContext context)
        {
            MenuHelper.PrintHeader("Book Registering");
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();
            int stock;
            while (true)
            {
                Console.Write("Enter Stock Balance: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out stock) && stock >= 0)
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a positive whole number.");
                Console.ResetColor();
            }

            var book = new Book { Title = title, Author = author, StockBalance = stock };
            context.Books.Add(book);
            context.SaveChanges();

            MenuHelper.SuccessMessage("Book registered successfully!");
        }

        public void AddMember(LibraryDbContext context)
        {
            MenuHelper.PrintHeader("Member Registering");
            Console.Write("Enter Full Name: ");
            string name = Console.ReadLine();

            context.LibraryMembers.Add(new LibraryMember { FullName = name });
            context.SaveChanges();

            MenuHelper.SuccessMessage("Member registered successfully!");
        }

        public void CreateLoan(LibraryDbContext context)
        {
            MenuHelper.PrintHeader("Register Loan");

            Console.Write("Enter Member ID: ");
            if (!int.TryParse(Console.ReadLine(), out int memberId)) return;

            
            Console.Write("Enter Book ID: ");
            if (!int.TryParse(Console.ReadLine(), out int bookId)) return;

            var book = context.Books.Find(bookId);
            var member = context.LibraryMembers.Find(memberId);

            if (book != null && member != null)
            {
                if (book.StockBalance > 0)
                {
                    var loan = new Loan
                    {
                        FkMemberId = memberId,
                        FkBookId = bookId,
                        LoanDate = DateTime.Now,
                    };

                    book.StockBalance--;
                    context.Loans.Add(loan);
                    context.SaveChanges();

                    MenuHelper.SuccessMessage($"Loan registered! '{book.Title}' lent to {member.FullName}.");
                }
                else
                {
                    MenuHelper.ErrorMessage("This book is currently out of stock.");
                }
            }
            else
            {
                MenuHelper.ErrorMessage("Member or Book ID not found.");
            }
        }

        public void ReturnBook(LibraryDbContext context)
        {
            MenuHelper.PrintHeader("Book Return");

            Console.Write("Enter Loan ID to return: ");
            if (!int.TryParse(Console.ReadLine(), out int loanId)) return;

            var loan = context.Loans.Include(l => l.FkBook).FirstOrDefault(l => l.LoanId == loanId);

            var alreadyReturned = context.BookReturns.Any(r => r.FkLoanId == loanId);

            if (loan != null && !alreadyReturned)
            {
                var bookReturn = new BookReturn
                {
                    FkLoanId = loanId,
                    ReturnDate = DateTime.Now
                };

                loan.FkBook.StockBalance++;
                context.BookReturns.Add(bookReturn);
                context.SaveChanges();

                MenuHelper.SuccessMessage($"Book '{loan.FkBook.Title}' has been returned.");
            }
            else
            {
                MenuHelper.ErrorMessage("Loan ID not found or book already returned.");
            }
        }

        public void ShowActiveLoans(LibraryDbContext context)
        {
            MenuHelper.PrintHeader("Active Loans");

            var activeLoans = context.ViewActiveLoans.ToList();

            if (!activeLoans.Any())
            {
                Console.WriteLine("No active loans found in the system.");
            }
            else
            {
                Console.WriteLine("{0,-10} {1,-20} {2,-25} {3,-15}", "Loan ID", "Member", "Book Title", "Date");
                Console.WriteLine(new string('-', 75));

                foreach (var l in activeLoans)
                {
                    Console.WriteLine("{0,-10} {1,-20} {2,-25} {3,-15}",
                        l.LoanId,
                        l.MemberName,
                        l.BookTitle,
                        l.LoanDate); 
                }
            }

            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }

        public void SearchBooks(LibraryDbContext context)
        {
            MenuHelper.PrintHeader("Book Search");
            Console.Write("Enter search term (Title or Author): ");
            string search = Console.ReadLine() ?? "";

            var results = context.Books
                .Where(b => b.Title.Contains(search) || b.Author.Contains(search))
                .ToList();

            if (!results.Any())
            {
                Console.WriteLine("No books matched your search.");
            }
            else
            {
                Console.WriteLine("\n{0,-5} {1,-30} {2,-20} {3,-10}", "ID", "Title", "Author", "In Stock");
                Console.WriteLine(new string('-', 70));

                foreach (var b in results)
                {
                    Console.WriteLine("{0,-5} {1,-30} {2,-20} {3,-10}",
                        b.BookId, b.Title, b.Author, b.StockBalance);
                }
            }
            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }

        public void ResetDatabase(LibraryDbContext context)
        {
            try
            {
                context.Database.ExecuteSqlRaw(@"
            DELETE FROM BookReturn;
            DELETE FROM Loan;
            DELETE FROM Book;
            DELETE FROM LibraryMember;

            DBCC CHECKIDENT ('BookReturn', RESEED, 0);
            DBCC CHECKIDENT ('Loan', RESEED, 0);
            DBCC CHECKIDENT ('Book', RESEED, 0);
            DBCC CHECKIDENT ('LibraryMember', RESEED, 0);
        ");

                MenuHelper.SuccessMessage("Database has been fully reset and IDs are restarted!");
            }
            catch (Exception ex)
            {
                MenuHelper.ErrorMessage("Reset failed: " + ex.Message);
            }
        }
    }
}
