using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
    }
}
