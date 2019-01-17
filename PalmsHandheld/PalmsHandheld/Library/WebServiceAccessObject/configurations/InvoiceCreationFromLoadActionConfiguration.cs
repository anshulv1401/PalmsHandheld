using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class InvoiceCreationFromLoadActionConfiguration : WebServiceAccessConfiguration<InvoiceCreationFromLoadActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public InvoiceCreationFromLoadActionConfiguration()
        {
            WebServiceName = "InvoiceCreationFromLoadAction.asmx";
            WebServicePath = "Actions";
        }

        public override InvoiceCreationFromLoadActionEntity CreateEntity()
        {
            return new InvoiceCreationFromLoadActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new InvoiceCreationFromLoadActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new InvoiceCreationFromLoadActionEntity().GetBlankUniqueKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey(string uniqueKey)
        {
            return (IEntityKey<Entity>)new InvoiceCreationFromLoadActionEntity().GetBlankUniqueKey("");
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
