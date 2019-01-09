using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class MiscellaneousReceiptFromHandheldCreateActionConfiguration : WebServiceAccessConfiguration<MiscellaneousReceiptFromHandheldCreateActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public MiscellaneousReceiptFromHandheldCreateActionConfiguration()
        {
            WebServiceName = "MiscellaneousReceiptFromHandheldCreateAction.asmx";
            WebServicePath = "Actions";
        }

        public override MiscellaneousReceiptFromHandheldCreateActionEntity CreateEntity()
        {
            return new MiscellaneousReceiptFromHandheldCreateActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new MiscellaneousReceiptFromHandheldCreateActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new MiscellaneousReceiptFromHandheldCreateActionEntity().GetBlankUniqueKey(uniqueKey);
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
