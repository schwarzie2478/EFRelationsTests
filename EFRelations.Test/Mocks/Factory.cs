using EFRelationTests.Model;
using EFRelationTests.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelations.Test.Mocks
{
    public class Factory
    {
        private static AppContext _context;
        public static AppContext Context
        {
            get
            {
                if(_context == null)
                {
                    _context = new AppContext();
                }
                return _context;
            }
            set
            {

            }
        }
        public static OrderRepository GetOrderRepo()
        {
            return new OrderRepository(Context);
        }
        public static CustomerRepository GetNewCustomerRepo()
        {
            return new CustomerRepository(new AppContext());
        }
        public static CustomerRepository GetCustomerRepo()
        {
            return new CustomerRepository(Context);
        }
        public static Customer CreateCustomer()
        {
            var customer = new Customer();
            customer.FirstName = "Default FirstName";
            customer.LastName = "Default LastName";
            customer.RegisteredSince = DateTime.Now.AddDays(-365);
            customer.BirthDay = new DateTime(1978, 6, 24);
            return customer;
        }
        public  static Order CreateOrder()
        {
            var order = new Order();
            order.Name = "Default Order";
            order.Description = "Default Description";
            order.ProcessingTicket = CreateProcessingTicket();
            order.OrderLines = new List<OrderLine>();
            order.OrderLines.Add(CreateOrderLine());
            return order;
        }
        public static OrderLine CreateOrderLine()
        {
            var orderLine = new OrderLine();
            orderLine.ProductType = "Default Product";
            orderLine.Quantity = 1.0;
            return orderLine;
        }
        public static ProcessingTicket CreateProcessingTicket()
        {
            var ticket = new ProcessingTicket();
            ticket.ProcessorName = "UPS Driver";
            ticket.ProcessingClass = "Next Day Delivery";
            return ticket;
        }
    }
}
