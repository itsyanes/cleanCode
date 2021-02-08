using ExamCleanCode.Core.Services.Data.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.Data.implementations
{
    public class BookRepositoryLoad : IRepositoryLoad<Book>
    {
        public ICollection<Book> GetAll()
        {
            var booksDataText = File.ReadAllText(Constants.BooksDataFilePath);
            var books = JsonConvert.DeserializeObject<ICollection<Book>>(booksDataText);
            return books;
        }

        public Book GetOne(string title)
        {
            var books = GetAll();
            return books.First(a => a.Title == title);
        }
    }
}
