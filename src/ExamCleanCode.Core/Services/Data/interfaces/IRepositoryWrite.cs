using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCleanCode.Core.Services.Data.interfaces
{
    public interface IRepositoryWrite<T>
    {
        public void Add(T entity);

        public void AddAll(ICollection<T> entities);
    }
}
