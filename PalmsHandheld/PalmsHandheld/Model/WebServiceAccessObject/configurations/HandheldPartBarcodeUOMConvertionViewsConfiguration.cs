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
    public class HandheldPartBarcodeUOMConvertionViewsConfiguration : WebServiceAccessConfiguration<HandheldPartBarcodeUOMConvertionViewsEntity>
    {
        private String WebServiceName;
        private String WebServicePath;

        public HandheldPartBarcodeUOMConvertionViewsConfiguration()
        {
            WebServiceName = "HandheldPartBarcodeUOMConvertionViews.asmx";
            WebServicePath = "Views";
        }

        public override HandheldPartBarcodeUOMConvertionViewsEntity CreateEntity()
        {
            return new HandheldPartBarcodeUOMConvertionViewsEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new HandheldPartBarcodeUOMConvertionViewsPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new HandheldPartBarcodeUOMConvertionViewsEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new HandheldPartBarcodeUOMConvertionViewsEntity().GetBlankUniqueKey(uniqueKey);
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
