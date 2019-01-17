using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PackCreateActionConfiguration : WebServiceAccessConfiguration<PackCreateActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PackCreateActionConfiguration()
        {
            WebServiceName = "PackCreateAction.asmx";
            WebServicePath = "Actions";
        }

        public override PackCreateActionEntity CreateEntity()
        {
            return new PackCreateActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PackCreateActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PackCreateActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PackCreateActionEntity().GetBlankUniqueKey(uniqueKey);
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
