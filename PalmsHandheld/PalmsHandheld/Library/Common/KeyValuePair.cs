using System;

namespace Technoforte.PALMS.Entities
{
	[Serializable]
	public class KeyValuePair
	{
		public string key;
		public string value;

        public KeyValuePair()
        {
            this.key = string.Empty;
            this.value = string.Empty;
        }
		public KeyValuePair(string key, string value)
		{
			this.key = key;
			this.value = value;
		}
	}
}
