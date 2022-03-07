using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBookStore.Models;

namespace WebBookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string BookName,string authorName)
        {
            return DataSource().Where(x => x.title.Contains(BookName) || x.author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
           {
                 new BookModel(){id=1,title="MVC",author="Nitish"},
                 new BookModel() { id = 2, title = "DotnetCore", author = "Nitish" },
                 new BookModel() { id = 3, title = "C#", author = "WebStore" },
                 new BookModel() { id = 4 ,title = "Java", author = "James" },
                 new BookModel() { id = 5, title = "PHP", author = "James" }

           };

        }
    }
}
