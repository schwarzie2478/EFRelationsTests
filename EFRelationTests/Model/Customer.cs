using ADF.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationTests.Model
{
    public class Customer: AuditableEntity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisteredSince { get; set; }
        public DateTime BirthDay { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
