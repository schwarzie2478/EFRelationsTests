using System;
using AutoMapper;
using EFRelationTests.Model;
using EFRelationTests.Contracts;

namespace EFRelationTests.Mappers
{
    public class CustomerMap : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}