using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>(){
                new BookModel(){Id = 1, Title = "MVC", Author = "A", Description="This is the description of MVC book"},
                new BookModel(){Id = 2, Title = "java", Author = "B", Description="This is the description of Java book"},
                new BookModel(){Id = 3, Title = "C++", Author = "C", Description="This is the description of C++ book"},
                new BookModel(){Id = 4, Title = "C#", Author = "D", Description="This is the description of C# book"},
                new BookModel(){Id = 5, Title = "Python", Author = "EEE", Description="This is the description of Python book"},
                new BookModel(){Id = 6, Title = ".NET", Author = "FFFF", Description="This is the description of .NET book"},

            };
        }
    }
}
