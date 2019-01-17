using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Actions;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.Views;

namespace Palms.Handheld
{
    public class WarehousePrimaryCompanyMappingConfiguration : WebServiceAccessConfiguration<WarehousePrimaryCompanyMappingEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public WarehousePrimaryCompanyMappingConfiguration()
        {
            WebServiceName = "WarehousePrimaryCompanyMapping.asmx";
            WebServicePath = "Views";
        }

        public override WarehousePrimaryCompanyMappingEntity CreateEntity()
        {
            return new WarehousePrimaryCompanyMappingEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new WarehousePrimaryCompanyMappingPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new WarehousePrimaryCompanyMappingEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new WarehousePrimaryCompanyMappingEntity().GetBlankUniqueKey(uniqueKey);
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
