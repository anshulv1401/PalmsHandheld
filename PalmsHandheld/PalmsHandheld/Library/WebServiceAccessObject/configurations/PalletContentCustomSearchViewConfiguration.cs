using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.Views.UniqueKeys;
using Technoforte.PALMS.Entities.Views;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;

namespace Palms.Handheld
{
    public class PalletContentCustomSearchViewConfiguration : WebServiceAccessConfiguration<PalletContentCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public PalletContentCustomSearchViewConfiguration()
        {
            WebServiceName = "PalletContentCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override PalletContentCustomSearchViewEntity CreateEntity()
        {
            return new PalletContentCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new PalletContentCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new PalletContentCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new PalletContentCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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