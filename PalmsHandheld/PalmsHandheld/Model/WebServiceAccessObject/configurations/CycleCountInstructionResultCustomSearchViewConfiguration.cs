using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.UniqueKeys;

namespace Palms.Handheld
{
    public class CycleCountInstructionResultCustomSearchViewConfiguration : WebServiceAccessConfiguration<CycleCountInstructionResultCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public CycleCountInstructionResultCustomSearchViewConfiguration()
        {
            WebServiceName = "CycleCountInstructionResultCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override CycleCountInstructionResultCustomSearchViewEntity CreateEntity()
        {
            return new CycleCountInstructionResultCustomSearchViewEntity();
        }

        public override IEntityKey<Entity>  CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new CycleCountInstructionResultCustomSearchViewPrimaryKey();
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
