using System;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Views;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;

namespace Palms.Handheld
{
    public class TransactionTypeConfiguration : WebServiceAccessConfiguration<TransactionTypeEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public TransactionTypeConfiguration()
        {
            WebServiceName = "TransactionType.asmx";
            WebServicePath = "Views";
        }

        public override TransactionTypeEntity CreateEntity()
        {
            return new TransactionTypeEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new TransactionTypePrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new TransactionTypeEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new TransactionTypeEntity().GetBlankUniqueKey(uniqueKey);
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
