using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class StockBucketFromHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<StockBucketFromHandheldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public StockBucketFromHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "StockBucketFromHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override StockBucketFromHandheldCustomSearchViewEntity CreateEntity()
        {
            return new StockBucketFromHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new StockBucketFromHandheldCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new StockBucketFromHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new StockBucketFromHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
