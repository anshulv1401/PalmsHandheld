using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class QuickTransferFromHandheldDropActionConfiguration : WebServiceAccessConfiguration<QuickTransferFromHandHeldDropActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public QuickTransferFromHandheldDropActionConfiguration()
        {
            WebServiceName = "QuickTransferFromHandHeldDropAction.asmx";
            WebServicePath = "Actions";
        }

        public override QuickTransferFromHandHeldDropActionEntity CreateEntity()
        {
            return new QuickTransferFromHandHeldDropActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new QuickTransferFromHandHeldDropActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new QuickTransferFromHandHeldDropActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new QuickTransferFromHandHeldDropActionEntity().GetBlankUniqueKey(uniqueKey);
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
