using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PartPickingFromHandheldDropActionConfiguration : WebServiceAccessConfiguration<PartPickingFromHandheldDropActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartPickingFromHandheldDropActionConfiguration()
        {
            WebServiceName = "PartPickingFromHandheldDropAction.asmx";
            WebServicePath = "Actions";
        }

        public override PartPickingFromHandheldDropActionEntity CreateEntity()
        {
            return new PartPickingFromHandheldDropActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartPickingFromHandheldDropActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartPickingFromHandheldDropActionEntity().GetBlankUniqueKey(uniqueKey);
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
