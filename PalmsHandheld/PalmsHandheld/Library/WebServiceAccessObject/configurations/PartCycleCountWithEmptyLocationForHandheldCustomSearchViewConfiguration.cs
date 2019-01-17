using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
   public class PartCycleCountWithEmptyLocationForHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<PartCycleCountWithEmptyLocationForHandheldCustomSearchViewEntity>
   {
        private String WebServiceName;
        private String WebServicePath;

        public PartCycleCountWithEmptyLocationForHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "PartCycleCountWithEmptyLocationForHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override PartCycleCountWithEmptyLocationForHandheldCustomSearchViewEntity CreateEntity()
        {
            return new PartCycleCountWithEmptyLocationForHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PartCycleCountWithEmptyLocationForHandheldCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartCycleCountWithEmptyLocationForHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartCycleCountWithEmptyLocationForHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
