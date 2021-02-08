using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.interfaces
{
    public interface IAuthentification
    {
        public User Login(string Login);
    }
}
