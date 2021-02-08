using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core
{
    public class User
    {
        public string Login { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Guest = 1,
        Librarian = 2,
        Member = 3
    }
}
