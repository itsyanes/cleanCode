using ExamCleanCode.Core.Services.Data.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.Data.implementations
{
    public class UserRepositoryWrite : IRepositoryWrite<User>
    {
        private readonly IRepositoryLoad<User> _userLoadRepository;

        public UserRepositoryWrite(IRepositoryLoad<User> userLoadRepository)
        {
            _userLoadRepository = userLoadRepository;
        }

        public void Add(User user)
        {
            var users = _userLoadRepository.GetAll();
            users.Add(user);
            File.WriteAllText(Constants.UsersDataFilePath, JsonConvert.SerializeObject(users));
        }

        public void AddAll(ICollection<User> entities)
        {
            File.WriteAllText(Constants.UsersDataFilePath, JsonConvert.SerializeObject(entities));
        }
    }
}
