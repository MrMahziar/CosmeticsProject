using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Entities;

namespace Cosmetics.EF.Persistance.CosmeticsDatabase
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext dBContext;

        public UnitOfWork(AppDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public Task Save()
        {
            return dBContext.SaveChangesAsync();
        }
    }
}
