using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class StockTakingInstructionCloseHHTActionConfiguration : WebServiceAccessConfiguration<StockTakingInstructionCloseHHTActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public StockTakingInstructionCloseHHTActionConfiguration()
        {
            WebServiceName = "StockTakingInstructionCloseHHTAction.asmx";
            WebServicePath = "Actions";
        }

        public override StockTakingInstructionCloseHHTActionEntity CreateEntity()
        {
            return new StockTakingInstructionCloseHHTActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new StockTakingInstructionCloseHHTActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new StockTakingInstructionCloseHHTActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new StockTakingInstructionCloseHHTActionEntity().GetBlankUniqueKey(uniqueKey);
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
