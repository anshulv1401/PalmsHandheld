using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class CycelCountInstructionConfirmationHHTActionConfiguration : WebServiceAccessConfiguration<CycleCountInstructionConfirmationHHTActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public CycelCountInstructionConfirmationHHTActionConfiguration()
        {
            WebServiceName = "CycleCountInstructionConfirmationHHTAction.asmx";
            WebServicePath = "Actions";
        }

        public override CycleCountInstructionConfirmationHHTActionEntity CreateEntity()
        {
            return new CycleCountInstructionConfirmationHHTActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new CycleCountInstructionConfirmationHHTActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new CycleCountInstructionConfirmationHHTActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new CycleCountInstructionConfirmationHHTActionEntity().GetBlankUniqueKey(uniqueKey);
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
