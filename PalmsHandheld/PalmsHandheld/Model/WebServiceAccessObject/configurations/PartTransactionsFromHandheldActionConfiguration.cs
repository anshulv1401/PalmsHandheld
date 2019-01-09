using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PartTransactionsFromHandheldActionConfiguration : WebServiceAccessConfiguration<PartTransactionsFromHandheldActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartTransactionsFromHandheldActionConfiguration()
        {
            WebServiceName = "PartTransactionsFromHandheldAction.asmx";
            WebServicePath = "Actions";
        }

        public override PartTransactionsFromHandheldActionEntity CreateEntity()
        {
            return new PartTransactionsFromHandheldActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PartTransactionsFromHandheldActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartTransactionsFromHandheldActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartTransactionsFromHandheldActionEntity().GetBlankUniqueKey(uniqueKey);
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
