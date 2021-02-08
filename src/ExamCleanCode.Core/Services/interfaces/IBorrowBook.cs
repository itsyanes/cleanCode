using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.interfaces
{
    public interface IBorrowBook
    {
        public void BorrowBook(User currentUser, string title);
    }
}
