using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.UniqueKeys;

namespace Palms.Handheld
{
    public class StockTakingInstructionResultCustomSearchViewsConfiguration : WebServiceAccessConfiguration<StockTakingInstructionResultCustomSearchViewsEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public StockTakingInstructionResultCustomSearchViewsConfiguration()
        {
            WebServiceName = "StockTakingInstructionResultCustomSearchViews.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override StockTakingInstructionResultCustomSearchViewsEntity CreateEntity()
        {
            return new StockTakingInstructionResultCustomSearchViewsEntity();
        }

        public override IEntityKey<Entity>  CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new StockTakingInstructionResultCustomSearchViewsPrimaryKey();
        }

        public override IEntityKey<Entity>  CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new StockTakingInstructionResultCustomSearchViewsEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity>  CreateUniqueKey(string uniqueKey)
        {
            return (IEntityKey<Entity>)new StockTakingInstructionResultCustomSearchViewsEntity().GetBlankUniqueKey("");
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
