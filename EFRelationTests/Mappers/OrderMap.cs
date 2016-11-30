using System;
using AutoMapper;
using EFRelationTests.Model;
using EFRelationTests.Contracts;

namespace EFRelationTests.Mappers
{
    public  class OrderMap : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Order, OrderDto>();
            Mapper.CreateMap<OrderDto, Order>();

            Mapper.CreateMap<OrderLine, OrderLineDto>();
            Mapper.CreateMap<OrderLineDto, OrderLine>();
            Mapper.CreateMap<ProcessingTicket, ProcessingTicketDto>();
            Mapper.CreateMap<ProcessingTicketDto, ProcessingTicket>();
        }
    }
}