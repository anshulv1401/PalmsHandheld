using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.UniqueKeys;

namespace Palms.Handheld
{
    public class InvoiceCreationFromHandHeldCustomSearchViewConfiguration : WebServiceAccessConfiguration<InvoiceCreationFromHandHeldCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public InvoiceCreationFromHandHeldCustomSearchViewConfiguration()
        {
            WebServiceName = "InvoiceCreationFromHandHeldCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override InvoiceCreationFromHandHeldCustomSearchViewEntity  CreateEntity()
        {
            return new InvoiceCreationFromHandHeldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity>  CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new InvoiceCreationFromHandHeldCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity>  CreateUniqueKey()
        {            
            return (IEntityKey<Entity>)new InvoiceCreationFromHandHeldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity>  CreateUniqueKey(string uniqueKey)
        {
            return (IEntityKey<Entity>)new InvoiceCreationFromHandHeldCustomSearchViewEntity().GetBlankUniqueKey("");
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
