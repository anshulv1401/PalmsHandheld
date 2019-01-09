using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;
using Technoforte.PALMS.Entities;

namespace Palms.Handheld.Library.WebServiceAccessObject.configurations
{
    public class WeightCaptureForGateInwardCustomSearchViewConfiguration : WebServiceAccessConfiguration<WeightCaptureForGateInwardCustomSearchViewEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public WeightCaptureForGateInwardCustomSearchViewConfiguration()
        {
            WebServiceName = "WeightCaptureForGateInwardCustomSearchView.asmx";
            WebServicePath = "CustomSearchViews";
        }

        public override WeightCaptureForGateInwardCustomSearchViewEntity CreateEntity()
        {
            return new WeightCaptureForGateInwardCustomSearchViewEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new WeightCaptureForGateInwardCustomSearchViewPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new WeightCaptureForGateInwardCustomSearchViewEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new WeightCaptureForGateInwardCustomSearchViewEntity().GetBlankUniqueKey(uniqueKey);
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
