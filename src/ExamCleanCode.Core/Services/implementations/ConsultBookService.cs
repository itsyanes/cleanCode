using ExamCleanCode.Core.Services.Data.interfaces;
using ExamCleanCode.Core.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.implementations
{
    public class ConsultBookService : IConsultBook
    {
        private readonly IUserAccess _accessService;
        private readonly IRepositoryLoad<Book> _bookLoadRepository;

        public ConsultBookService(IUserAccess accessService,
                                  IRepositoryLoad<Book> bookLoadRepository)
        {
            _accessService = accessService;
            _bookLoadRepository = bookLoadRepository;
        }
        public void SeeContent(User currentUser, string title)
        {
            if (!(_accessService.CanPerformAction(currentUser, Role.Librarian)) 
                && !(_accessService.CanPerformAction(currentUser, Role.Member))
                && !(_accessService.CanPerformAction(currentUser, Role.Guest)))
            {
                throw new Exception("You can't perform this action");
            }

            var book = _bookLoadRepository.GetOne(title);
            Console.WriteLine(book.Content);
        }
    }
}
