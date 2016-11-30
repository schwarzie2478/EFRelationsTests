using System;
using AutoMapper;
using EFRelationTests.Model;
using EFRelationTests.Contracts;
using EFRelationTests.Repositories;

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
    public class CustomerDtoMapper
    {

        private readonly ICustomerRepository _customerRepository;
        private IMapper _mapper;

        public CustomerDtoMapper(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _mapper = AutoMapperConfiguration.GetMapper();
        }

        public Customer Map(CustomerDto customer)
        {
            
            var cust = _customerRepository.Get(customer.Id);
            if(cust != null)
            {
                var newCustomer
                //Create
            }else
            {
                //Update data

                //UPdate Order if neccesary otherwire create
            }
        }

    }