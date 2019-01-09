using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class QuickTransferDropFromHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<QuickTransferDropFromHandheldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public QuickTransferDropFromHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "QuickTransferDropFromHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override QuickTransferDropFromHandheldCustomSearchViewEntity CreateEntity()
        {
            return new QuickTransferDropFromHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new QuickTransferDropFromHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new QuickTransferDropFromHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new QuickTransferDropFromHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
