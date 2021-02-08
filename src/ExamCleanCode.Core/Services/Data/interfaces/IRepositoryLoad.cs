using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.Data.interfaces
{
    public interface IRepositoryLoad<T>
    {
        public ICollection<T> GetAll();
        public T GetOne(string Id);
    }
}
