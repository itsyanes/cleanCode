using ExamCleanCode.Core.Services.Data.interfaces;
using ExamCleanCode.Core.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.implementations
{
    public class ReferenceBookService : IReferenceBook
    {
        private readonly IUserAccess _accessService;
        private readonly IRepositoryWrite<Book> _bookWriteRepository;

        public ReferenceBookService(IUserAccess accessService,
                                    IRepositoryWrite<Book> bookWriteRepository)
        {
            _accessService = accessService;
            _bookWriteRepository = bookWriteRepository;
        }

        public void AddBook(User currentUser, Book book)
        {
            if(!(_accessService.CanPerformAction(currentUser, Role.Librarian)))
            {
                throw new Exception("You can't perform this action");
            }

            _bookWriteRepository.Add(book);
        }
    }
}
