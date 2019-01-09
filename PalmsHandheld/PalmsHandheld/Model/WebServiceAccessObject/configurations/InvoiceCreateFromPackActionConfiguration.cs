using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class InvoiceCreateFromPackActionConfiguration : WebServiceAccessConfiguration<InvoiceCreateFromPackActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public InvoiceCreateFromPackActionConfiguration()
        {
            WebServiceName = "InvoiceCreateFromPackAction.asmx";
            WebServicePath = "Actions";
        }

        public override InvoiceCreateFromPackActionEntity CreateEntity()
        {
            return new InvoiceCreateFromPackActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new InvoiceCreateFromPackActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new InvoiceCreateFromPackActionEntity().GetBlankUniqueKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey(string uniqueKey)
        {
            return (IEntityKey<Entity>)new InvoiceCreateFromPackActionEntity().GetBlankUniqueKey("");
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
