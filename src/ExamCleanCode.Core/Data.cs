using ExamCleanCode.Core.Models;
using ExamCleanCode.Core.Services.Data.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core
{
    public class Data
    {
        public Library Library { get; set; }

        private readonly IRepositoryLoad<Book> _bookLoadRepository;
        private readonly IRepositoryLoad<User> _userLoadRepository;

        public Data(IRepositoryLoad<Book> bookLoadRepository,
                    IRepositoryLoad<User> userLoadRepository)
        {
            _bookLoadRepository = bookLoadRepository;
            _userLoadRepository = userLoadRepository;
        }

        public void LoadInitialData()
        {
            var books = _bookLoadRepository.GetAll();
            var users = _userLoadRepository.GetAll();

            Library = new Library(books, users);
        }
    }
}
