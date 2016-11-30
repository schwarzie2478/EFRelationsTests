using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationTests.Contracts
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisteredSince { get; set; }
        public DateTime BirthDay { get; set; }
        public List<OrderDto> Orders { get; set; }

    }
}
