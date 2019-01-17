using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.Views.UniqueKeys;
using Technoforte.PALMS.Entities.Views;

namespace Palms.Handheld
{
    public class PalletCreateActionConfiguration : WebServiceAccessConfiguration<PalletCreateActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PalletCreateActionConfiguration()
        {
            WebServiceName = "PalletCreateAction.asmx";
            WebServicePath = "Actions";
        }

        public override PalletCreateActionEntity CreateEntity()
        {
            return new PalletCreateActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return null;
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return null;
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return null;
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
