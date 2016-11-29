using ADF.Data.Repositories;
using System;

namespace EFRelationTests.Model
{
    public class OrderLine:AuditableEntity<Guid>
    {
        public string ProductType { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }

        public Order Order{get;set ;}
    }
}