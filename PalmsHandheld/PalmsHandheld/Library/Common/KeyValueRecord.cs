using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Technoforte.PALMS.Entities
{
	public class KeyValueRecord
	{
		protected Hashtable hash = new Hashtable();

		public void Add(KeyValuePair pair)
		{
			hash.Add(pair.key, pair);
		}

		public void Add(string key, string value)
		{
			hash.Add(key, new KeyValuePair(key, value));
		}

		public void Clear()
		{
			hash.Clear();
		}

		public KeyValuePair Get(string key)
		{
			if (hash.Contains(key))
			{
				return (KeyValuePair)hash[key];
			}
			else
			{
				return null;
			}
		}

		public string GetValue(string key)
		{
			if (hash.Contains(key))
			{
				return (((KeyValuePair)hash[key]).value==null ? "NULL" : ((KeyValuePair)hash[key]).value);
			}
			else
			{
				return "NULL";
			}
		}

        public ICollection Keys
        {
            get { return hash.Keys; }
        }
	}
}
