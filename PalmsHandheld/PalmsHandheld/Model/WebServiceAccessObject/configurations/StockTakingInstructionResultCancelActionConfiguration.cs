﻿using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class StockTakingInstructionResultCancelActionConfiguration : WebServiceAccessConfiguration<StockTakingInstructionResultCancelActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public StockTakingInstructionResultCancelActionConfiguration()
        {
            WebServiceName = "StockTakingInstructionResultCancelAction.asmx";
            WebServicePath = "Actions";
        }

        public override StockTakingInstructionResultCancelActionEntity CreateEntity()
        {
            return new StockTakingInstructionResultCancelActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new StockTakingInstructionResultCancelActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new StockTakingInstructionResultCancelActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new StockTakingInstructionResultCancelActionEntity().GetBlankUniqueKey(uniqueKey);
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
