using ADF.Data.Repositories;
using ADF.Data.Repositories.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationTests.Repositories
{
    public class AppContext: BaseContext<AppContext>
    {
        public AppContext():base(new CurrentPrincipalIdentityProvider())
        {
            Database.SetInitializer(new DropCreateDatabaseAlways< AppContext>());
            
        }
    }
}
