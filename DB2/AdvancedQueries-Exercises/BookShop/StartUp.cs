using System.Globalization;
using System.Text;
using BookShop.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace BookShop
{
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

            //Console.WriteLine(GetBooksByAgeRestriction(db, Console.ReadLine()));           //2
            //Console.WriteLine(GetGoldenBooks(db));                                         //3
            //Console.WriteLine(GetBooksByPrice(db));                                        //4
            //Console.WriteLine(GetBooksNotReleasedIn(db, int.Parse(Console.ReadLine())));   //5
            //Console.WriteLine(GetBooksByCategory(db, Console.ReadLine()));                 //6
            //Console.WriteLine(GetBooksReleasedBefore(db,Console.ReadLine()));              //7
            //Console.WriteLine(GetAuthorNamesEndingIn(db, Console.ReadLine()));             //8
            //Console.WriteLine(GetBookTitlesContaining(db, Console.ReadLine()));            //9
            //Console.WriteLine(GetBooksByAuthor(db, Console.ReadLine()));                   //10
            //Console.WriteLine(CountBooks(db, int.Parse(Console.ReadLine())));              //11
            //Console.WriteLine(CountCopiesByAuthor(db));                                    //12
            //Console.WriteLine(GetTotalProfitByCategory(db));                               //13
            //Console.WriteLine(GetMostRecentBooks(db));                                     //14
            //IncreasePrices(db);                                                            //15
            //Console.WriteLine(RemoveBooks(db));                                            //16
        }

        public static int RemoveBooks(BookShopContext context)  //16
        {
            var books = context.Books
                .Where(b => b.Copies < 4200);

            int count = 0;

            foreach (var book in books)
            {
                context.Books.Remove(book);
                count++;
            }

            context.SaveChanges();

            return count;
        }
        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList();

            foreach (var book in books)
            {
                book.Price += 5;
            }
            context.SaveChanges();
        } //15
        public static string GetMostRecentBooks(BookShopContext context)  //14
        {
            var categories = context.Categories

                .Select(c => new
                {
                    c.Name,
                    Top3Books = c.CategoryBooks
                        .OrderByDescending(cb => cb.Book.ReleaseDate)
                        .Take(3)
                        .Select(cb => new
                        {
                            cb.Book.Title,
                            cb.Book.ReleaseDate.Value.Year
                        })

                })
                .OrderBy(c => c.Name);

            StringBuilder sb = new();
            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.Name}");

                foreach (var top3Book in category.Top3Books)

                {
                    sb.AppendLine($"{top3Book.Title} ({top3Book.Year})");
                }
            }

            return sb.ToString().Trim();
        }
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                .Select(c => new
                {
                    c.Name,
                    profit = c.CategoryBooks.Sum(cb => cb.Book.Price * cb.Book.Copies)
                })
                .OrderByDescending(c => c.profit)
                .ThenBy(c => c.Name)
                .ToArray();



            return string.Join(Environment.NewLine, categories.Select(c => $"{c.Name} ${c.profit:f2}"));
        } //13
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors
                .Select(a => new
                {
                    AuthorName = $"{a.FirstName} {a.LastName}",
                    copies = a.Books.Select(b => b.Copies).Sum()
                })
                .OrderByDescending(a => a.copies)
                .ToArray();

            return string.Join(Environment.NewLine, authors.Select(a => $"{a.AuthorName} - {a.copies}"));
        }  //12
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            return context.Books
                .Count(b => b.Title.Length > lengthCheck);



        } //11
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    AuthorName = $"({b.Author.FirstName} {b.Author.LastName})"
                })
                .OrderBy(b => b.BookId)
                .ToArray();

            return string.Join(Environment.NewLine, books.Select(b => $"{b.Title} {b.AuthorName}"));
        } //10
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var titles = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => b.Title)
                .ToList()
                .OrderBy(t => t);

            return string.Join(Environment.NewLine, titles);
        }  //9
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => $"{a.FirstName} {a.LastName}")
                .ToArray()
                .OrderBy(a => a);


            return string.Join(Environment.NewLine, authors);
        }  //8
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            DateTime filter = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate < filter)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price,
                    b.ReleaseDate
                })
                .OrderByDescending(b => b.ReleaseDate)
                .ToArray();




            return string.Join(Environment.NewLine, books.Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:f2}"));
        } //7
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            var books = context.Books
                .Where(b => b.BookCategories.Any(bc => categories.Contains(bc.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToArray();

            //var books = context.BooksCategories
            //    .Where(bc => categories.Contains(bc.Category.Name))
            //    .Select(b => b.Book.Title)
            //    .OrderBy(b => b)
            //    .ToList();

            return string.Join(Environment.NewLine, books);
        } //6
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .Select(b => new
                {
                    b.BookId,
                    b.Title
                })
                .OrderBy(b => b.BookId)
                .ToArray();

            return string.Join(Environment.NewLine, books.Select(b => $"{b.Title}"));
        } // 5
        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToArray();

            return string.Join(Environment.NewLine, books.Select(b => $"{b.Title} - ${b.Price:f2}"));
        } // 4
        public static string GetGoldenBooks(BookShopContext context)
        {
            var titles = context.Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .Select(b => new
                {
                    b.BookId,
                    b.Title
                })
                .OrderBy(b => b.BookId)
                .ToList();
            StringBuilder sb = new StringBuilder();

            foreach (var title in titles)
            {
                sb.AppendLine(title.Title);
            }

            return sb.ToString().Trim();
        }  // 3
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            if (!Enum.TryParse(command, true, out AgeRestriction ageRestriction))
            {
                return "";
            }

            var bookTitles = context.Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToArray();

            return string.Join(Environment.NewLine, bookTitles);
        }   // 2


    }
}


