﻿using EFRelationTests.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationTests.Repositories
{
    public class OrderLineConfiguration: EntityTypeConfiguration<OrderLine>
    {
        public OrderLineConfiguration()
        {
            ToTable("OrderLines", "dbo")
                .HasKey(e => e.Id)
                .Property(e => e.Id).HasColumnName("Id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

        }
    }
}
