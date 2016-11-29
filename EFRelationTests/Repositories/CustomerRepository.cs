using EFRelationTests.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationTests.Repositories
{
    public class CustomerRepository: ADF.Data.Repositories.EF.EF6CrudRepository<Guid, Customer>, ICustomerRepository
    {
        private DbContext _context;
        public CustomerRepository(DbContext dbContext):base(dbContext)
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
