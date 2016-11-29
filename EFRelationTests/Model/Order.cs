using ADF.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationTests.Model
{
    public class Order : AuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
        public virtual ProcessingTicket ProcessingTicket { get; set; }
        public virtual Customer Customer { get; set;}
        public Guid Customer_Id { get;  set; }
    }
}
