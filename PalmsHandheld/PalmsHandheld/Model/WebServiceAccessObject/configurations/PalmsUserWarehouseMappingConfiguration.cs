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
    public class PalmsUserWarehouseMappingConfiguration : WebServiceAccessConfiguration<PalmsUserWarehouseMappingEntity>
    {
        private String WebServiceName;
        private String WebServicePath;      

        public PalmsUserWarehouseMappingConfiguration()
        {
            WebServiceName = "PalmsUserWarehouseMapping.asmx";
            WebServicePath = "Views";
        }

        public override PalmsUserWarehouseMappingEntity CreateEntity()
        {
            return new PalmsUserWarehouseMappingEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PalmsUserWarehouseMappingEntity().GetBlankUniqueKey(uniqueKey);
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
