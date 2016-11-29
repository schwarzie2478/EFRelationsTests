using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFRelationTests.Model;
using System.Data.Entity;

namespace EFRelationTests.Repositories
{
    public class OrderRepository : ADF.Data.Repositories.EF.EF6CrudRepository<Guid,Order>,IOrderRepository
    {
        private DbContext _context;
        public OrderRepository(DbContext dbContext):base(dbContext)
        {
            _context = dbContext;
        }
        public DbContext DbContext
        {
            get
            {
                return _context;
            }
            set
            {
                _context = value;
            }
        }

    }
}
