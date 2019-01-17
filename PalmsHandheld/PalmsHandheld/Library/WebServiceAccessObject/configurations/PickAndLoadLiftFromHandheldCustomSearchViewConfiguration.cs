using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class PickAndLoadLiftFromHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<PickAndLoadLiftFromHandheldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PickAndLoadLiftFromHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "PickAndLoadLiftFromHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override PickAndLoadLiftFromHandheldCustomSearchViewEntity CreateEntity()
        {
            return new PickAndLoadLiftFromHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PickAndLoadLiftFromHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PickAndLoadLiftFromHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PickAndLoadLiftFromHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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