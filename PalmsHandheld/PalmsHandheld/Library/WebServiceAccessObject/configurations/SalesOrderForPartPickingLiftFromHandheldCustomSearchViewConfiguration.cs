using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class SalesOrderForPartPickingLiftFromHandheldCustomSearchViewConfiguration : WebServiceAccessConfiguration<SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity>
    {
        private String webServiceName;
        private String webServicePath;

        public SalesOrderForPartPickingLiftFromHandheldCustomSearchViewConfiguration()
	    {
            webServiceName = "SalesOrderForPartPickingLiftFromHandheldCustomSearchView.asmx";
            webServicePath = "CustomSearchViews";
	    }

        public SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity createEntity()
	    {
            return new SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity();
	    }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
        }

        public override String GetWebServiceName()
        {
            return webServiceName;
        }

        public override String GetWebServicePath()
        {
            return webServicePath;
        }

        public override SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity CreateEntity()
        {
            throw new NotImplementedException();
        }
    }
}
