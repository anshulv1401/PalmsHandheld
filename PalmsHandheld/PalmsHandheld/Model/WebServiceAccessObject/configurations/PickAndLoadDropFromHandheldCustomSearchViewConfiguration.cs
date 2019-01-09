using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class PickAndLoadDropFromHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<PickAndLoadDropFromHandheldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PickAndLoadDropFromHandheldCustomSearchViewConfiguration()
        {
            WebServiceName = "PickAndLoadDropFromHandheldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override PickAndLoadDropFromHandheldCustomSearchViewEntity CreateEntity()
        {
            return new PickAndLoadDropFromHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PickAndLoadDropFromHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PickAndLoadDropFromHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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