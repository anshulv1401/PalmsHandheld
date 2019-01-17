using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class InternalStockTransferLiftFromHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<InternalStockTransferLiftFromHandheldCustomSearchViewEntity>
    {
        private String webServiceName;
        private String webServicePath;

        public InternalStockTransferLiftFromHandheldCustomSearchViewConfiguration()
	    {
            webServiceName = "InternalStockTransferLiftFromHandheldCustomSearchView.asmx";
		    webServicePath = "CustomSearchViews";
	    }

        public InternalStockTransferLiftFromHandheldCustomSearchViewEntity createEntity()
	    {
            return new InternalStockTransferLiftFromHandheldCustomSearchViewEntity();
	    }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new InternalStockTransferLiftFromHandheldCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new InternalStockTransferLiftFromHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new InternalStockTransferLiftFromHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
        }

        public override String GetWebServiceName()
        {
            return webServiceName;
        }

        public override String GetWebServicePath()
        {
            return webServicePath;
        }

        public override InternalStockTransferLiftFromHandheldCustomSearchViewEntity CreateEntity()
        {
            throw new NotImplementedException();
        }
    }
}
