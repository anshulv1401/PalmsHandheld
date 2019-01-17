using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class CycleCountInstructionCloseHHTActionConfiguration : WebServiceAccessConfiguration<CycleCountInstructionCloseHHTActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public CycleCountInstructionCloseHHTActionConfiguration()
        {
            WebServiceName = "CycleCountInstructionCloseHHTAction.asmx";
            WebServicePath = "Actions";
        }

        public override CycleCountInstructionCloseHHTActionEntity CreateEntity()
        {
            return new CycleCountInstructionCloseHHTActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new CycleCountInstructionCloseHHTActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new CycleCountInstructionCloseHHTActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new CycleCountInstructionCloseHHTActionEntity().GetBlankUniqueKey(uniqueKey);
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
