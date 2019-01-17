using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PartPickingFromHandheldLiftActionConfiguration : WebServiceAccessConfiguration<PartPickingFromHandheldLiftActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartPickingFromHandheldLiftActionConfiguration()
        {
            WebServiceName = "PartPickingFromHandheldLiftAction.asmx";
            WebServicePath = "Actions";
        }

        public override PartPickingFromHandheldLiftActionEntity CreateEntity()
        {
            return new PartPickingFromHandheldLiftActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartPickingFromHandheldLiftActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartPickingFromHandheldLiftActionEntity().GetBlankUniqueKey(uniqueKey);
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
