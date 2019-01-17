using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.UniqueKeys;

namespace Palms.Handheld.Library.WebServiceAccessObject.configurations
{
    public class InvoiceCreationFromPickingPartLineCustomSearchViewConfiguration : WebServiceAccessConfiguration<InvoiceCreationFromPickingPartLineCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public InvoiceCreationFromPickingPartLineCustomSearchViewConfiguration()
        {
            WebServiceName = "InvoiceCreationFromPickingPartLineCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }
        public override InvoiceCreationFromPickingPartLineCustomSearchViewEntity CreateEntity()
        {
            return new InvoiceCreationFromPickingPartLineCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new InvoiceCreationFromPickingPartLineCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new InvoiceCreationFromPickingPartLineCustomSearchViewUniqueKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey(string uniqueKey)
        {
            return (IEntityKey<Entity>)new InvoiceCreationFromPickingPartLineCustomSearchViewUniqueKey();
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
