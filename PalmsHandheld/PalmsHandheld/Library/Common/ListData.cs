using System;
using System.Collections.Generic;
using System.Linq;
using Technoforte.PALMS.Entities;

namespace Technoforte.PALMS.WebServices
{
	[Serializable]
	public class ListData<E>
		where E : Entity,new()
		
	{
		public List<EntityKey<E>> primaryKeys { get; set; }
        public List<EntityKey<E>> uniqueKeys { get; set; }
		public long totalRecords { get; set; }
		public ErrorInformation error { get; set; }

		public ListData()
		{
			this.error = new ErrorInformation("", "");
		}

		public ListData(List<E> entities)
		{
			this.error = new ErrorInformation("", "");
            this.primaryKeys = new List<EntityKey<E>>();
			this.totalRecords = entities.Count;
            this.uniqueKeys = new List<EntityKey<E>>();

			foreach (E entity in entities)
			{
                this.primaryKeys.Add((EntityKey<E>)entity.GetPrimaryKey());
                this.uniqueKeys.Add((EntityKey<E>)entity.GetUniqueKey());
			}

            this.primaryKeys.AsEnumerable();
            this.uniqueKeys.AsEnumerable();
		}

		public ListData(Exception e, ServiceErrorType errorType)
		{
			this.error = new ErrorInformation(e, errorType);
			this.primaryKeys = null;
			this.totalRecords = 0;
			this.uniqueKeys = null;
		}
	}
}
