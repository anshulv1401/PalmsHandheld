﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Technoforte.PALMS.Entities;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.Views.UniqueKeys;
//using Technoforte.PALMS.Entities.Actions;
//using Technoforte.PALMS.Entities.CustomSearchViews;
//using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;
using Technoforte.PALMS.Entities.Views;

namespace Palms.Handheld
{
    public class EnumerationConfiguration : WebServiceAccessConfiguration<EnumerationEntity>
    {
        private String WebServiceName;
        private String WebServicePath;      

        public EnumerationConfiguration()
        {
            WebServiceName = "Enumeration.asmx";
            WebServicePath = "Views";
        }

        public override EnumerationEntity CreateEntity()
        {
            return new EnumerationEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new EnumerationPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new EnumerationEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new EnumerationEntity().GetBlankUniqueKey(uniqueKey);
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
