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
    public class PartCategoryConfiguration : WebServiceAccessConfiguration<PartCategoryEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartCategoryConfiguration()
        {
            WebServiceName = "PartCategory.asmx";
            WebServicePath = "Views";
        }

        public override PartCategoryEntity CreateEntity()
        {
            return new PartCategoryEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PartCategoryPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartCategoryEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartCategoryEntity().GetBlankUniqueKey(uniqueKey);
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
