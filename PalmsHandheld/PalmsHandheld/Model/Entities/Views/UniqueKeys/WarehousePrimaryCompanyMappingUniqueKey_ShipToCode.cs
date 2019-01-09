//// Warning: Do not modify!
//// This file (WarehousePrimaryCompanyMappingUniqueKey_ShipToCode.cs) has been auto-generated by PALMS Entity Generation Tool on '26 February 2013' at '09:51:23'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.UniqueKeys
{
	[Serializable]
	public partial class WarehousePrimaryCompanyMappingUniqueKey_ShipToCode : EntityKey<WarehousePrimaryCompanyMappingEntity>
	{
		#region Enums

		public enum Field
		{
			WarehousePrimaryCompanyShipToCode
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public string warehousePrimaryCompanyShipToCode;

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
				case Field.WarehousePrimaryCompanyShipToCode:
					return warehousePrimaryCompanyShipToCode;
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
				case Field.WarehousePrimaryCompanyShipToCode:
					return typeof(string);
			}

			return null;
		}

		public override WarehousePrimaryCompanyMappingEntity GetBlankEntityWithKey()
		{
			return new WarehousePrimaryCompanyMappingEntity()
			{
				warehousePrimaryCompanyShipToCode = warehousePrimaryCompanyShipToCode
			};
		}

		public override string GetClassName()
		{
			return "WarehousePrimaryCompanyMappingUniqueKey_ShipToCode";
		}

		#endregion Overriding / Public Members
	}
}