using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class VehicleCreateActionConfiguration : WebServiceAccessConfiguration<VehicleCreateActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public VehicleCreateActionConfiguration()
        {
            WebServiceName = "VehicleCreateAction.asmx";
            WebServicePath = "Actions";
        }

        public override VehicleCreateActionEntity CreateEntity()
        {
            return new VehicleCreateActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new VehicleCreateActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new VehicleCreateActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new VehicleCreateActionEntity().GetBlankUniqueKey(uniqueKey);
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
