using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PickAndLoadFromHandheldDropActionConfiguration : WebServiceAccessConfiguration<PickAndLoadFromHandheldDropActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PickAndLoadFromHandheldDropActionConfiguration()
        {
            WebServiceName = "PickAndLoadFromHandheldDropAction.asmx";
            WebServicePath = "Actions";
        }

        public override PickAndLoadFromHandheldDropActionEntity CreateEntity()
        {
            return new PickAndLoadFromHandheldDropActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PickAndLoadFromHandheldDropActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PickAndLoadFromHandheldDropActionEntity().GetBlankUniqueKey(uniqueKey);
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
