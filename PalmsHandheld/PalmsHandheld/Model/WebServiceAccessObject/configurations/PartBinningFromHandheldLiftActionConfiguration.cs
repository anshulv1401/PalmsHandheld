using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PartBinningFromHandheldLiftActionConfiguration : WebServiceAccessConfiguration<PartBinningFromHandheldLiftActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartBinningFromHandheldLiftActionConfiguration()
        {
            WebServiceName = "PartBinningFromHandheldLiftAction.asmx";
            WebServicePath = "Actions";
        }

        public override PartBinningFromHandheldLiftActionEntity CreateEntity()
        {
            return new PartBinningFromHandheldLiftActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartBinningFromHandheldLiftActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartBinningFromHandheldLiftActionEntity().GetBlankUniqueKey(uniqueKey);
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
