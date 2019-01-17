using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class QuickTransferFromHandheldLiftActionConfiguration : WebServiceAccessConfiguration<QuickTransferFromHandheldLiftActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public QuickTransferFromHandheldLiftActionConfiguration()
        {
            WebServiceName = "QuickTransferFromHandheldLiftAction.asmx";
            WebServicePath = "Actions";
        }

        public override QuickTransferFromHandheldLiftActionEntity CreateEntity()
        {
            return new QuickTransferFromHandheldLiftActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new QuickTransferFromHandheldLiftActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new QuickTransferFromHandheldLiftActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new QuickTransferFromHandheldLiftActionEntity().GetBlankUniqueKey(uniqueKey);
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
