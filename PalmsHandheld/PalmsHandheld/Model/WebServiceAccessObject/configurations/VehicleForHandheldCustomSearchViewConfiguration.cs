using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class VehicleForHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<VehicleForHandheldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public VehicleForHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "VehicleForHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override VehicleForHandheldCustomSearchViewEntity CreateEntity()
        {
            return new VehicleForHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new VehicleForHandheldCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new VehicleForHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new VehicleForHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
