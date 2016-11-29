using ADF.Data.Repositories;
using EFRelationTests.Model;
using System;
using System.Data.Entity;

namespace EFRelationTests.Repositories
{
    public  interface ICustomerRepository: ICrudRepository<Guid, Customer>
    {
        DbContext DbContext { get; set; }
    }
}