using ExamCleanCode.Core.Interfaces;
using ExamCleanCode.Core.Services.Data.interfaces;
using ExamCleanCode.Core.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core
{
    public class ConsoleLauncher : IConsoleUserInterface
    {
        private readonly IRepositoryWrite<User> _userWriteRepository;
        private readonly IAuthentification _authService;
        private readonly IBorrowBook _borrowService;
        private readonly IReferenceBook _referenceService;
        private readonly IConsultBook _consultService;
        private User currentUser;
        public ConsoleLauncher(IRepositoryWrite<User> userWriteRepository,
                               IAuthentification authentification,
                               IBorrowBook borrowService,
                               IReferenceBook referenceService,
                               IConsultBook consultService)
        {
            _userWriteRepository = userWriteRepository;
            _authService = authentification;
            _borrowService = borrowService;
            _referenceService = referenceService;
            _consultService = consultService;
        }
        public void LaunchUserInterface()
        {
            Console.WriteLine("Welcome to Solid Library App");
            Authenticate();
            LaunchOptions();
        }

        private void Authenticate()
        {
            Console.WriteLine("You want to: (specify number)");
            Console.WriteLine("1- Login");
            Console.WriteLine("2- Register");
            int choice;
            while ((choice = int.Parse(Console.ReadLine())) != 1 && choice != 2)
            {
                Console.WriteLine("Please enter a valid choice");
            }
            if (choice == 1)
            {
                Console.WriteLine("Please enter your login");
                string login = Console.ReadLine();
                while (_authService.Login(login) == null)
                {
                    Console.WriteLine("Please enter a valid login");
                }
                currentUser = _authService.Login(login);
            }
            else
            {
                Console.WriteLine("Please enter your new login");
                string login = Console.ReadLine();
                Console.WriteLine("Please enter your role");
                Console.WriteLine("1- Guest");
                Console.WriteLine("2- Librarian");
                Console.WriteLine("3- Member");
                int role = int.Parse(Console.ReadLine());
                var user = new User
                {
                    Login = login,
                    Role = (Role)role
                };
                _userWriteRepository.Add(user);
                currentUser = user;
            }
        }

        private void LaunchOptions()
        {
            Console.WriteLine("What would you like to do ? (specify number)");
            Console.WriteLine("1- Add/Reference Book");
            Console.WriteLine("2- See content of a book");
            Console.WriteLine("3- Borrow book");
            Console.WriteLine("4- Exit");
            int option;
            while ((option = int.Parse(Console.ReadLine())) != 4)
            {
                try
                {
                    switch (option)
                    {
                        case 1:
                            ReferenceBook();
                            break;
                        case 2:
                            SeeBookContent();
                            break;
                        case 3:
                            BorrowBook();
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                } catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }

        }

        private void ReferenceBook()
        {
            Console.WriteLine("The book title ?");
            string title = Console.ReadLine();
            Console.WriteLine("The book author ?");
            string author = Console.ReadLine();
            _referenceService.AddBook(currentUser, new Book
            {
                Title = title,
                Author = author
            });
            Console.WriteLine("Success!");
        }

        private void SeeBookContent()
        {
            Console.WriteLine("The book title ?");
            string title = Console.ReadLine();
            _consultService.SeeContent(currentUser, title);
        }

        private void BorrowBook()
        {
            Console.WriteLine("The book title ?");
            string title = Console.ReadLine();
            _borrowService.BorrowBook(currentUser, title);
        }
    }
}
