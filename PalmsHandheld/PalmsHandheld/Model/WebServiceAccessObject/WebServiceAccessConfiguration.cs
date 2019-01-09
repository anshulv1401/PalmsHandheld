using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Technoforte.PALMS.Entities;



namespace Palms.Handheld
{
    public abstract class WebServiceAccessConfiguration<E> where E : Entity 
    {
        public abstract E CreateEntity();

        public abstract IEntityKey<Entity> CreatePrimaryKey();

        public abstract IEntityKey<Entity> CreateUniqueKey();

        public abstract IEntityKey<Entity> CreateUniqueKey(String uniqueKey);

        public abstract String GetWebServiceName();

        public abstract String GetWebServicePath();

    }
}
