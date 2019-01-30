using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using GMS.Data.DBContext.Interface;

namespace GMS.Data.DBContext.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly crudEntities _dbContext;

        public UnitOfWork()
        {
            _dbContext = new crudEntities();
        }

        public DbContext Db
        {
            get { return _dbContext; }
        }

        public void Dispose()
        {
        }
    }
}
