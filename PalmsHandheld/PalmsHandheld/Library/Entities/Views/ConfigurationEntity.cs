//// Warning: Do not modify!
//// This file (ConfigurationEntity.cs) has been auto-generated by PALMS Entity Generation Tool on '05 May 2015' at '14:52:15'
//// If modification is required, consider 'partial class'.

using System;
using System.Collections;
using System.Collections.Generic;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.Views.UniqueKeys;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views
{
	[Serializable]
	public partial class ConfigurationEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			KeyName
			, KeyValue
            , PrimaryCompanyID
            , WarehouseID
			, _FieldCount
		}

		public enum UniqueKey
		{
			Default
		}

		#endregion Enums

		#region Members

		public string keyName;
		public string keyValue;
        public int? primaryCompanyID;
        public int? warehouseID;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new ConfigurationPrimaryKey()
			{
				keyName = (string)keyName
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new ConfigurationPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<ConfigurationEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new ConfigurationUniqueKey()
					{
						keyName = (string)keyName
					};
			}

			return null;
		}

		public override IEntityKey<Entity> GetBlankUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetBlankUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<ConfigurationEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new ConfigurationUniqueKey();
			}

			return null;
		}

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
				case Field.KeyValue:
					return keyValue;
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
				case Field.KeyValue:
					return typeof(string);
                case Field.PrimaryCompanyID:
                    return typeof(int?);
                case Field.WarehouseID:
                    return typeof(int?);
			}

			return null;
		}

		public override void SetValue(int field, bool? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, bool? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, long? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, long? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, int? value)
		{
			SetValue((Field)field, value);
		}

        public void SetValue(Field field, int? value)
        {
            switch (field)
            {
                case Field.PrimaryCompanyID:
                    primaryCompanyID = value;
                    break;
                case Field.WarehouseID:
                    warehouseID = value;
                    break;
                default:
                    break;
            }
        }

		public override void SetValue(int field, short? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, short? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, byte? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, byte? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, BitArray value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, BitArray value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, float? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, float? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, double? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, double? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, decimal? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, decimal? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, char? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, char? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, string value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, string value)
		{
			switch (field)
			{
				case Field.KeyName:
					keyName = value;
					break;
				case Field.KeyValue:
					keyValue = value;
					break;
				default:
					break;
			}
		}

		public override void SetValue(int field, DateTime? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, DateTime? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, Guid? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, Guid? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override bool IsIdentity(int field)
		{
			return false;
		}

		#endregion Overriding / Public Members
	}
}