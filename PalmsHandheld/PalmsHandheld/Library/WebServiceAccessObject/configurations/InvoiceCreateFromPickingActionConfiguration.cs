using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.Views.UniqueKeys;
using Technoforte.PALMS.Entities.Views;
using Technoforte.PALMS.Entities.Actions;

namespace Palms.Handheld
{
    public class InvoiceCreateFromPickingActionConfiguration : WebServiceAccessConfiguration<InvoiceCreateFromPickingActionEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public InvoiceCreateFromPickingActionConfiguration()
        {
            WebServiceName = "InvoiceCreateFromPickingAction.asmx";
            WebServicePath = "Actions";
        }

        public override InvoiceCreateFromPickingActionEntity CreateEntity()
        {
            return new InvoiceCreateFromPickingActionEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new InvoiceCreateFromPickingActionEntity().GetBlankPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new InvoiceCreateFromPickingActionEntity().GetUniqueKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey(string uniqueKey)
        {
            return (IEntityKey<Entity>)new InvoiceCreateFromPickingActionEntity().GetUniqueKey("");
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
