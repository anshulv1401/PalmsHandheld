using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class InvoiceCloseActionConfiguration : WebServiceAccessConfiguration<InvoiceCloseActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public InvoiceCloseActionConfiguration()
        {
            WebServiceName = "InvoiceCloseAction.asmx";
            WebServicePath = "Actions";
        }

        public override InvoiceCloseActionEntity CreateEntity()
        {
            return new InvoiceCloseActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new InvoiceCloseActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new InvoiceCloseActionEntity().GetBlankUniqueKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey(string uniqueKey)
        {
            return (IEntityKey<Entity>)new InvoiceCloseActionEntity().GetBlankUniqueKey("");
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
