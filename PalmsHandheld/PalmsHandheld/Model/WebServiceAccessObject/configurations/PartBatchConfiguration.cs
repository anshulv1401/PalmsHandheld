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
    public class PartBatchConfiguration : WebServiceAccessConfiguration<PartBatchEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PartBatchConfiguration()
        {
            WebServiceName = "PartBatch.asmx";
            WebServicePath = "Views";
        }

        public override PartBatchEntity CreateEntity()
        {
            return new PartBatchEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PartBatchPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PartBatchEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PartBatchEntity().GetBlankUniqueKey(uniqueKey);
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
