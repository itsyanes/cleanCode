using ExamCleanCode.Core.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.implementations
{
    public class UserAccessService : IUserAccess
    {
        public bool CanPerformAction(User user, Role requiredRole)
        {
            return user.Role == requiredRole;
        }
    }
}
