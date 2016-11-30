using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationTests.Mappers
{
    public static class AutoMapperConfiguration
    {
        private static MapperConfiguration _configuration;

        public static MapperConfiguration Configuration
        {
            get
            {
                if (_configuration == null) GetConfiguration();
                return _configuration;
            }
        }

        private static void GetConfiguration()
        {
            _configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CustomerMap>();
                cfg.AddProfile<OrderMap>();
            });

        }

        public static IMapper GetMapper()
        {
            return Configuration.CreateMapper();
        }
    }
}
