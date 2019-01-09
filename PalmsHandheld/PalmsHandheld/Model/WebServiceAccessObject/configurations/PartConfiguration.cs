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
    public class PartConfiguration : WebServiceAccessConfiguration<PartEntity>
    {
        private String WebServiceName;
        private String WebServicePath;      

        public PartConfiguration()
        {
            WebServiceName = "Part.asmx";
            WebServicePath = "Views";
        }

        public override PartEntity CreateEntity()
        {
            return new PartEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PartPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartEntity().GetBlankUniqueKey(uniqueKey);
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
