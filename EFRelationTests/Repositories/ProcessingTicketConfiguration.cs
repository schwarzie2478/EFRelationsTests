using EFRelationTests.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationTests.Repositories
{
    public class ProcessingTicketConfiguration : EntityTypeConfiguration<ProcessingTicket>
    {
        public ProcessingTicketConfiguration()
        {
            ToTable("ProcessingTicket", "dbo")
                .HasKey(e => e.Id)
                .Property(e => e.Id).HasColumnName("Id");
                



        }
    }
}
