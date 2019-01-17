using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class LocationForHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<LocationForHandheldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public LocationForHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "LocationForHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override LocationForHandheldCustomSearchViewEntity CreateEntity()
        {
            return new LocationForHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new LocationForHandheldCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new LocationForHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new LocationForHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
