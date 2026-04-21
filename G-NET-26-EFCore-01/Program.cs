using G_NET_26_EFCore_01.Models;

namespace G_NET_26_EFCore_01
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            /*  CASE STUDY: BOOKSTORE
                You are hired as a junior developer at &quot;ReadMore Books&quot;, a
                small bookstore that
                needs a simple database system. The owner explains: &quot;We
                need to track our book
                inventory - each book has a title, ISBN number, price, number
                of pages, the year
                it was published, and whether it&#39;s currently in stock. We also
                want to keep
                information about the authors we work with, including their
                first and last names,
                email addresses, a short biography, and their date of birth.
                Finally, we organize
                our books into different categories - each category has a
                name, description, and
                we need to know if the category is still active or not.&quot;
                --------------------------------------------------------------------
                Requirements:
                1. Create a Console Application using Entity Framework Core
                2. Use EF Core CONVENTIONS ONLY
                3. Use Sql Server as the database provider
                4. Identify and create the necessary entities from the case study
                5. Create an appropriate DbContext class
                6. Demonstrate that the database is created correctly
            */

            using (AppDbContext dbContext = new AppDbContext()) 
            {
                var category = new Category
                {
                    Name = "Programming",
                    Description = "Programming Books",
                    IsActive = true
                };

                var author = new Author
                {
                    FirstName = "Ahmed",
                    LastName = "Ali",
                    Email = "ahmed@test.com",
                    Bio = "Software Developer",
                    DateOfBirth = new DateTime(1995, 5, 1)
                };

                var book = new Book
                {
                    Title = "C# Basics",
                    ISBN = "123456",
                    Price = 150,
                    Pages = 300,
                    YearPublished = 2023,
                    IsInStock = true,
                    Category = category,
                    Authors = new List<Author> { author }
                };

                dbContext.Books.Add(book);
                dbContext.SaveChanges();

                Console.WriteLine("Database Created & Data Inserted Successfully");

            }
        }
    }
}
