using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class SupplierCustomSearchViewConfiguration : WebServiceAccessConfiguration<SupplierCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public SupplierCustomSearchViewConfiguration()
        {
            WebServiceName = "SupplierCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override SupplierCustomSearchViewEntity CreateEntity()
        {
            return new SupplierCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new SupplierCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new SupplierCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new SupplierCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
