using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class StockTakingInstructionConfirmationHHTActionConfiguration : WebServiceAccessConfiguration<StockTakingInstructionConfirmationHHTActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public StockTakingInstructionConfirmationHHTActionConfiguration()
        {
            WebServiceName = "StockTakingInstructionConfirmationHHTAction.asmx";
            WebServicePath = "Actions";
        }

        public override StockTakingInstructionConfirmationHHTActionEntity CreateEntity()
        {
            return new StockTakingInstructionConfirmationHHTActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new StockTakingInstructionConfirmationHHTActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new StockTakingInstructionConfirmationHHTActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new StockTakingInstructionConfirmationHHTActionEntity().GetBlankUniqueKey(uniqueKey);
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
