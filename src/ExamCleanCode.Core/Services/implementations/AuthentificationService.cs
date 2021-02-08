using ExamCleanCode.Core.Services.Data.interfaces;
using ExamCleanCode.Core.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.implementations
{
    public class AuthentificationService : IAuthentification
    {
        private readonly IRepositoryLoad<User> _userLoadRepository;

        public AuthentificationService(IRepositoryLoad<User> userLoadRepository)
        {
            _userLoadRepository = userLoadRepository;
        }

        public User Login(string Login)
        {
            var users = _userLoadRepository.GetAll();
            return users.First(a => a.Login == Login);
        }
    }
}
