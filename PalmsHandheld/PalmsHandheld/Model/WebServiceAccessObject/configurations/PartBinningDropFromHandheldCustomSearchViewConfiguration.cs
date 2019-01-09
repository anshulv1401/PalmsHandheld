using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PartBinningDropFromHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<PartBinningDropFromHandheldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartBinningDropFromHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "PartBinningDropFromHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override PartBinningDropFromHandheldCustomSearchViewEntity CreateEntity()
        {
            return new PartBinningDropFromHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartBinningDropFromHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartBinningDropFromHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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