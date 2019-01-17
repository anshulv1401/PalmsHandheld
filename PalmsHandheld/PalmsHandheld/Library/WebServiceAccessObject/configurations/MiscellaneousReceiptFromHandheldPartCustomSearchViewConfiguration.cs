using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class MiscellaneousReceiptFromHandheldPartCustomSearchViewConfiguration : WebServiceAccessConfiguration<MiscellaneousReceiptFromHandheldPartCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public MiscellaneousReceiptFromHandheldPartCustomSearchViewConfiguration()
        {
            WebServiceName = "MiscellaneousReceiptFromHandheldPartCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override MiscellaneousReceiptFromHandheldPartCustomSearchViewEntity CreateEntity()
        {
            return new MiscellaneousReceiptFromHandheldPartCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new MiscellaneousReceiptFromHandheldPartCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new MiscellaneousReceiptFromHandheldPartCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new MiscellaneousReceiptFromHandheldPartCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
