//// Warning: Do not modify!
//// This file (WarehousePrimaryCompanyMappingUniqueKey_PrimaryCompanyWarehouse.cs) has been auto-generated by PALMS Entity Generation Tool on '26 February 2013' at '09:51:23'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.UniqueKeys
{
	[Serializable]
	public partial class WarehousePrimaryCompanyMappingUniqueKey_PrimaryCompanyWarehouse : EntityKey<WarehousePrimaryCompanyMappingEntity>
	{
		#region Enums

		public enum Field
		{
			PrimaryCompanyID
			, WarehouseID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? primaryCompanyID;
		public int? warehouseID;

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
				case Field.PrimaryCompanyID:
					return primaryCompanyID;
				case Field.WarehouseID:
					return warehouseID;
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
				case Field.PrimaryCompanyID:
					return typeof(int?);
				case Field.WarehouseID:
					return typeof(int?);
			}

			return null;
		}

		public override WarehousePrimaryCompanyMappingEntity GetBlankEntityWithKey()
		{
			return new WarehousePrimaryCompanyMappingEntity()
			{
				primaryCompanyID = primaryCompanyID
				, warehouseID = warehouseID
			};
		}

		public override string GetClassName()
		{
			return "WarehousePrimaryCompanyMappingUniqueKey_PrimaryCompanyWarehouse";
		}

		#endregion Overriding / Public Members
	}
}
