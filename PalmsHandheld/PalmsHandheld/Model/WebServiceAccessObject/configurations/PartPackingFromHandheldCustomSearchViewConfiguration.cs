using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class PartPackingFromHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<PartPackingFromHandheldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartPackingFromHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "PartPackingFromHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override PartPackingFromHandheldCustomSearchViewEntity CreateEntity()
        {
            return new PartPackingFromHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PartPackingFromHandheldCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartPackingFromHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartPackingFromHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
