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
    public class BookRepositoryWrite : IRepositoryWrite<Book>
    {
        private readonly IRepositoryLoad<Book> _bookLoadRepository;

        public BookRepositoryWrite(IRepositoryLoad<Book> bookLoadRepository)
        {
            _bookLoadRepository = bookLoadRepository;
        }
        public void Add(Book entity)
        {
            var books = _bookLoadRepository.GetAll();
            books.Add(entity);
            File.WriteAllText(Constants.BooksDataFilePath, JsonConvert.SerializeObject(books));
        }

        public void AddAll(ICollection<Book> entities)
        {
            File.WriteAllText(Constants.BooksDataFilePath, JsonConvert.SerializeObject(entities));
        }
    }
}
