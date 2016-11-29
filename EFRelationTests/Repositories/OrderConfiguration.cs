using EFRelationTests.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationTests.Repositories
{
    public class OrderConfiguration: EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            ToTable("Order", "dbo")
                .HasKey(e => e.Id)
                .Property(e => e.Id).HasColumnName("Id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            HasRequired(o => o.ProcessingTicket)
            .WithRequiredPrincipal(p => p.Order);
            HasRequired<Customer>(o => o.Customer).WithOptional(c => c.Order);
        }
    }
}
