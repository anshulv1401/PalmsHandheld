using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;

namespace Palms.Handheld.Library.WebServiceAccessObject.configurations
{
    public class WeightCaptureForGateInwardFromHHTActionConfiguration : WebServiceAccessConfiguration<WeightCaptureForGateInwardFromHHTActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public WeightCaptureForGateInwardFromHHTActionConfiguration()
        {
            WebServiceName = "WeightCaptureForGateInwardFromHHTAction.asmx";
            WebServicePath = "Actions";
        }

        public override WeightCaptureForGateInwardFromHHTActionEntity CreateEntity()
        {
            return new WeightCaptureForGateInwardFromHHTActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new WeightCaptureForGateInwardFromHHTActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new WeightCaptureForGateInwardFromHHTActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new WeightCaptureForGateInwardFromHHTActionEntity().GetBlankUniqueKey(uniqueKey);
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
