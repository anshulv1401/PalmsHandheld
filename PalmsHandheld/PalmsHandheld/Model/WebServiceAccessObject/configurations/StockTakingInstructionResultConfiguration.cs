using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.Views.UniqueKeys;
using Technoforte.PALMS.Entities.Views;

namespace Palms.Handheld
{
    public class StockTakingInstructionResultConfiguration : WebServiceAccessConfiguration<StockTakingInstructionResultEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public StockTakingInstructionResultConfiguration()
        {
            WebServiceName = "StockTakingInstructionResult.asmx";
            WebServicePath = "Views";
        }

        public override StockTakingInstructionResultEntity CreateEntity()
        {
            return new StockTakingInstructionResultEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PartPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new StockTakingInstructionResultEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new StockTakingInstructionResultEntity().GetBlankUniqueKey(uniqueKey);
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
