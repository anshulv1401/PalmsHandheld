using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class PackForHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<PackForHandheldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PackForHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "PackForHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override PackForHandheldCustomSearchViewEntity CreateEntity()
        {
            return new PackForHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PackForHandheldCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PackForHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PackForHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
