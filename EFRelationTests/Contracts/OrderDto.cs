using System;
using System.Collections.Generic;

namespace EFRelationTests.Contracts
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  List<OrderLineDto> OrderLines { get; set; }
        public  ProcessingTicketDto ProcessingTicket { get; set; }
        public  CustomerDto Customer { get; set; }
    }
}