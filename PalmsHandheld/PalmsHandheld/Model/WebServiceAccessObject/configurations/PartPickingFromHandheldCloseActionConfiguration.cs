using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PartPickingFromHandheldCloseActionConfiguration : WebServiceAccessConfiguration<PartPickingFromHandheldCloseActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartPickingFromHandheldCloseActionConfiguration()
        {
            WebServiceName = "PartPickingFromHandheldCloseAction.asmx";
            WebServicePath = "Actions";
        }

        public override PartPickingFromHandheldCloseActionEntity CreateEntity()
        {
            return new PartPickingFromHandheldCloseActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartPickingFromHandheldCloseActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartPickingFromHandheldCloseActionEntity().GetBlankUniqueKey(uniqueKey);
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
