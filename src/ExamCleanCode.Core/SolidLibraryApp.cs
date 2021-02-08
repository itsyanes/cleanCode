using ExamCleanCode.Core.Services.Data.implementations;
using ExamCleanCode.Core.Services.implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core
{
    public class SolidLibraryApp
    {
        public Data AppData { get; set; }
        public void Execute()
        {
            var book = new BookRepositoryLoad();
            var user = new UserRepositoryLoad();
            var auth = new AuthentificationService(user);
            var userWrite = new UserRepositoryWrite(user);
            var bookWrite = new BookRepositoryWrite(book);
            AppData = new Data(book,user);
            AppData.LoadInitialData();

            var access = new UserAccessService();
            var borrow = new BorrowBookService(access, book, bookWrite);
            var reference = new ReferenceBookService(access,bookWrite);
            var consult = new ConsultBookService(access, book);

            ConsoleLauncher consoleLauncher = new ConsoleLauncher(userWrite, auth, borrow, reference, consult);
            consoleLauncher.LaunchUserInterface();
        }
    }
}
