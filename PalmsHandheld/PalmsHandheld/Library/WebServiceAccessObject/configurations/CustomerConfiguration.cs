using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Technoforte.PALMS.Entities.Views;
using Technoforte.PALMS.Entities;

namespace Palms.Handheld.Library.WebServiceAccessObject.configurations
{
    public class CustomerConfiguration : WebServiceAccessConfiguration<CustomerEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public CustomerConfiguration()
        {
            WebServiceName = "Customer.asmx";
            WebServicePath = "Views";
        }

        public override CustomerEntity CreateEntity()
        {
            return new CustomerEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new CustomerEntity();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new CustomerEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new CustomerEntity().GetBlankUniqueKey(uniqueKey);
        }

        public override String GetWebServiceName()
        {
            return WebServiceName;
        }

        public override String GetWebServicePath()
        {
            return WebServicePath;
        }
    }
}
