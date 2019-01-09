using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class PartStockWithEmptyLocationForHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<PartStockWithEmptyLocationForHandheldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartStockWithEmptyLocationForHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "PartStockWithEmptyLocationForHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override PartStockWithEmptyLocationForHandheldCustomSearchViewEntity CreateEntity()
        {
            return new PartStockWithEmptyLocationForHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PartStockWithEmptyLocationForHandheldCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartStockWithEmptyLocationForHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartStockWithEmptyLocationForHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
