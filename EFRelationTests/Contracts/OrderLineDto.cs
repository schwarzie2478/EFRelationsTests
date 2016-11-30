using System;

namespace EFRelationTests.Contracts
{
    public class OrderLineDto
    {
        public Guid Id { get; set; }
        public string ProductType { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public OrderDto Order { get; set; }
    }
}