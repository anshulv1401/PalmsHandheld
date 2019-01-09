//// Warning: Do not modify!
//// This file (ConfigurationUniqueKey.cs) has been auto-generated by PALMS Entity Generation Tool on '05 May 2015' at '14:52:15'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.UniqueKeys
{
	[Serializable]
	public partial class ConfigurationUniqueKey : EntityKey<ConfigurationEntity>
	{
		#region Enums

		public enum Field
		{
			KeyName
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public string keyName;

		#endregion Members

		#region Overriding / Public Members

		public override int GetFieldCount()
		{
			return (int)Field._FieldCount;
		}

		public override object GetValue(int field)
		{
			return GetValue((Field)field);
		}

		public object GetValue(Field field)
		{
			switch (field)
			{
				case Field.KeyName:
					return keyName;
			}

			return null;
		}

		public override string GetFieldName(int field)
		{
			return GetFieldName((Field)field);
		}

		public string GetFieldName(Field field)
		{
			return field.ToString();
		}

		public override Type GetType(int field)
		{
			return GetType((Field)field);
		}

		public Type GetType(Field field)
		{
			switch (field)
			{
				case Field.KeyName:
					return typeof(string);
			}

			return null;
		}

		public override ConfigurationEntity GetBlankEntityWithKey()
		{
			return new ConfigurationEntity()
			{
				keyName = keyName
			};
		}

		public override string GetClassName()
		{
			return "ConfigurationUniqueKey";
		}

		#endregion Overriding / Public Members
	}
}