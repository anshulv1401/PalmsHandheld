//// Warning: Do not modify!
//// This file (PackTypeEntity.cs) has been auto-generated by PALMS Entity Generation Tool on '03 June 2013' at '15:40:10'
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
	public partial class PackTypeEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PackTypeID
			, PackTypeName
			, PackTypeCode
			, HierarchyLevel
			, AllowMixedShippingInfoData
			, IsTransportPack
			, CreatedBy_PalmsUserLoginName
			, ModifiedBy_PalmsUserLoginName
			
			, _FieldCount
		}

		public enum UniqueKey
		{
			Code
			, Name
		}

		#endregion Enums

		#region Members

		public int? packTypeID;
		public string packTypeName;
		public string packTypeCode;
		public int? hierarchyLevel;
		public bool? allowMixedShippingInfoData;
		public bool? isTransportPack;
		public string createdBy_PalmsUserLoginName;
		public string modifiedBy_PalmsUserLoginName;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new PackTypePrimaryKey()
			{
				packTypeID = (int)packTypeID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new PackTypePrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Name";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<PackTypeEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Code:
					return new PackTypeUniqueKey_Code()
					{
						packTypeCode = (string)packTypeCode
					};
				case UniqueKey.Name:
					return new PackTypeUniqueKey_Name()
					{
						packTypeName = (string)packTypeName
					};
			}

			return null;
		}

		public override IEntityKey<Entity> GetBlankUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Name";
			}

			return (IEntityKey<Entity>)GetBlankUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<PackTypeEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Code:
					return new PackTypeUniqueKey_Code();
				case UniqueKey.Name:
					return new PackTypeUniqueKey_Name();
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
				case Field.PackTypeID:
					return packTypeID;
				case Field.PackTypeName:
					return packTypeName;
				case Field.PackTypeCode:
					return packTypeCode;
				case Field.HierarchyLevel:
					return hierarchyLevel;
				case Field.AllowMixedShippingInfoData:
					return allowMixedShippingInfoData;
				case Field.IsTransportPack:
					return isTransportPack;
				case Field.CreatedBy_PalmsUserLoginName:
					return createdBy_PalmsUserLoginName;
				case Field.ModifiedBy_PalmsUserLoginName:
					return modifiedBy_PalmsUserLoginName;
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
				case Field.PackTypeID:
					return typeof(int?);
				case Field.PackTypeName:
					return typeof(string);
				case Field.PackTypeCode:
					return typeof(string);
				case Field.HierarchyLevel:
					return typeof(int?);
				case Field.AllowMixedShippingInfoData:
					return typeof(bool?);
				case Field.IsTransportPack:
					return typeof(bool?);
				case Field.CreatedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.ModifiedBy_PalmsUserLoginName:
					return typeof(string);

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
				case Field.AllowMixedShippingInfoData:
					allowMixedShippingInfoData = value;
					break;
				case Field.IsTransportPack:
					isTransportPack = value;
					break;
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
				case Field.PackTypeID:
					packTypeID = value;
					break;
				case Field.HierarchyLevel:
					hierarchyLevel = value;
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
				case Field.PackTypeName:
					packTypeName = value;
					break;
				case Field.PackTypeCode:
					packTypeCode = value;
					break;
				case Field.CreatedBy_PalmsUserLoginName:
					createdBy_PalmsUserLoginName = value;
					break;
				case Field.ModifiedBy_PalmsUserLoginName:
					modifiedBy_PalmsUserLoginName = value;
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
			if ((Field)field == Field.PackTypeID)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion Overriding / Public Members
	}
}
