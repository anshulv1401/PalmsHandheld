using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PartBinningFromHandheldDropActionConfiguration : WebServiceAccessConfiguration<PartBinningFromHandheldDropActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartBinningFromHandheldDropActionConfiguration()
        {
            WebServiceName = "PartBinningFromHandheldDropAction.asmx";
            WebServicePath = "Actions";
        }

        public override PartBinningFromHandheldDropActionEntity CreateEntity()
        {
            return new PartBinningFromHandheldDropActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartBinningFromHandheldDropActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartBinningFromHandheldDropActionEntity().GetBlankUniqueKey(uniqueKey);
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
