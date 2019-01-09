using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.UniqueKeys;
using Technoforte.PALMS.Entities.CustomSearchViews;

namespace Palms.Handheld
{
    public class LocationSelectionConfiguration : WebServiceAccessConfiguration<LocationSelectionCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public LocationSelectionConfiguration()
        {
            WebServiceName = "LocationSelectionCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override LocationSelectionCustomSearchViewEntity CreateEntity()
        {
            return new LocationSelectionCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new LocationSelectionCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new LocationSelectionCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new LocationSelectionCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
