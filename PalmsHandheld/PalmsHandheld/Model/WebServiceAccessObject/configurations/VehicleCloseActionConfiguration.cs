using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class VehicleCloseActionConfiguration : WebServiceAccessConfiguration<VehicleCloseActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public VehicleCloseActionConfiguration()
        {
            WebServiceName = "VehicleCloseAction.asmx";
            WebServicePath = "Actions";
        }

        public override VehicleCloseActionEntity CreateEntity()
        {
            return new VehicleCloseActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new VehicleCloseActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new VehicleCloseActionEntity().GetBlankUniqueKey(uniqueKey);
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
