using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities;

namespace Palms.Handheld
{
    public class PartWithStorageUOMAndBillingUOMCustomSearchViewConfiguration : WebServiceAccessConfiguration<PartWithStorageUOMAndBillingUOMCustomSearchViewEntity>
    {
        private String webServiceName;
        private String webServicePath;

        public PartWithStorageUOMAndBillingUOMCustomSearchViewConfiguration()
	    {
            webServiceName = "PartWithStorageUOMAndBillingUOMCustomSearchView.asmx";
            webServicePath = "CustomSearchViews";
	    }

        public PartWithStorageUOMAndBillingUOMCustomSearchViewEntity createEntity()
	    {
            return new PartWithStorageUOMAndBillingUOMCustomSearchViewEntity();
	    }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PartWithStorageUOMAndBillingUOMCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartWithStorageUOMAndBillingUOMCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartWithStorageUOMAndBillingUOMCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
        }

        public override String GetWebServiceName()
        {
            return webServiceName;
        }

        public override String GetWebServicePath()
        {
            return webServicePath;
        }

        public override PartWithStorageUOMAndBillingUOMCustomSearchViewEntity CreateEntity()
        {
            throw new NotImplementedException();
        }
    }
}
