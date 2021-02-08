using ExamCleanCode.Core.Services.Data.interfaces;
using ExamCleanCode.Core.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.implementations
{
    public class BorrowBookService : IBorrowBook
    {
        private readonly IUserAccess _accessService;
        private readonly IRepositoryLoad<Book> _bookLoadRepository;
        private readonly IRepositoryWrite<Book> _bookWriteRepository;

        public BorrowBookService(IUserAccess accessService,
                       IRepositoryLoad<Book> bookLoadRepository,
                       IRepositoryWrite<Book> bookWriteRepository)
        {
            _accessService = accessService;
            _bookLoadRepository = bookLoadRepository;
            _bookWriteRepository = bookWriteRepository;
        }
        public void BorrowBook(User currentUser, string title)
        {
            if (!(_accessService.CanPerformAction(currentUser, Role.Member)))
            {
                throw new Exception("You can't perform this action");
            }

            var books = _bookLoadRepository.GetAll();
            var book = books.First(a => a.Title == title);
            if(book == null)
                throw new Exception("This book doesn't exist");

            if(book.Borrower != null)
                throw new Exception("This book is already borrowed");

            book.Borrower = currentUser.Login;
            book.BorrowDate = DateTime.Now;

            _bookWriteRepository.AddAll(books);
        }
    }
}
