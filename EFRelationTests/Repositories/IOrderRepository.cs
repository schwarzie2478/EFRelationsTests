using ADF.Data.Repositories;
using EFRelationTests.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationTests.Repositories
{
    public interface IOrderRepository: ICrudRepository<Guid, Order>
    {
        DbContext DbContext { get; set; }
    }
}
