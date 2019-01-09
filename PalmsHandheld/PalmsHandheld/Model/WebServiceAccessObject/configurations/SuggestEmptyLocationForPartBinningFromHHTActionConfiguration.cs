using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class SuggestEmptyLocationForPartBinningFromHHTActionConfiguration : WebServiceAccessConfiguration<SuggestEmptyLocationForPartBinningFromHHTActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public SuggestEmptyLocationForPartBinningFromHHTActionConfiguration()
        {
            WebServiceName = "SuggestEmptyLocationForPartBinningFromHHTAction.asmx";
            WebServicePath = "Actions";
        }

        public override SuggestEmptyLocationForPartBinningFromHHTActionEntity CreateEntity()
        {
            return new SuggestEmptyLocationForPartBinningFromHHTActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new SuggestEmptyLocationForPartBinningFromHHTActionEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new SuggestEmptyLocationForPartBinningFromHHTActionEntity().GetBlankUniqueKey(uniqueKey);
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
