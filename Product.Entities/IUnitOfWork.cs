using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Entities
{
    public interface IUnitOfWork
    {
        Task Save();
    }
}
