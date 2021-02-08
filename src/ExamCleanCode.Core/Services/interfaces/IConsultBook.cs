using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.interfaces
{
    public interface IConsultBook
    {
        public void SeeContent(User currentUser, string title);
    }
}
