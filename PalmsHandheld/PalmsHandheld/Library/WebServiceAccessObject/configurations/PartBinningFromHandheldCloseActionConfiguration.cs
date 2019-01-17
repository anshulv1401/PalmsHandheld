using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PartBinningFromHandheldCloseActionConfiguration : WebServiceAccessConfiguration<PartBinningFromHandheldCloseActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartBinningFromHandheldCloseActionConfiguration()
        {
            WebServiceName = "PartBinningFromHandheldCloseAction.asmx";
            WebServicePath = "Actions";
        }

        public override PartBinningFromHandheldCloseActionEntity CreateEntity()
        {
            return new PartBinningFromHandheldCloseActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartBinningFromHandheldCloseActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartBinningFromHandheldCloseActionEntity().GetBlankUniqueKey(uniqueKey);
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
