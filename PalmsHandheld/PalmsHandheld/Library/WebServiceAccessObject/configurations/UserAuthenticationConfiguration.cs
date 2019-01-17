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
    public class UserAuthenticationConfiguration : WebServiceAccessConfiguration<UserAuthenticationEntity>
    {
        private String WebServiceName;
        private String WebServicePath;      

        public UserAuthenticationConfiguration()
        {
            WebServiceName = "UserAuthentication.asmx";
            WebServicePath = "Views";
        }

        public override UserAuthenticationEntity CreateEntity()
        {
            return new UserAuthenticationEntity();
        }

        public override IEntityKey<Entity> CreatePrimaryKey()
        {
            return (IEntityKey<Entity>)new UserAuthenticationPrimaryKey();
        }

        public override IEntityKey<Entity> CreateUniqueKey()
        {
            return (IEntityKey<Entity>)new UserAuthenticationEntity().GetBlankUniqueKey("");
        }

        public override IEntityKey<Entity> CreateUniqueKey(String uniqueKey)
        {
            return (IEntityKey<Entity>)new UserAuthenticationEntity().GetBlankUniqueKey(uniqueKey);
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
