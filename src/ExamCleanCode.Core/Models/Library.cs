using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Models
{
    public class Library
    {
        public ICollection<Book> Books { get; set; }
        public ICollection<User> RegisteredUsers { get; set; }

        public Library(ICollection<Book> books, ICollection<User> users)
        {
            Books = books;
            RegisteredUsers = users;
        }
    }
}
