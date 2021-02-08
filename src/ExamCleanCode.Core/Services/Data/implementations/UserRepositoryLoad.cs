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
    public class UserRepositoryLoad : IRepositoryLoad<User>
    {
        public ICollection<User> GetAll()
        {
            var usersDataText = File.ReadAllText(Constants.UsersDataFilePath);
            var users = JsonConvert.DeserializeObject<ICollection<User>>(usersDataText);
            return users;
        }

        public User GetOne(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
