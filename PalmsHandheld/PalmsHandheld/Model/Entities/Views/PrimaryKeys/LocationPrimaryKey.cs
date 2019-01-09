//// Warning: Do not modify!
//// This file (LocationPrimaryKey.cs) has been auto-generated by PALMS Entity Generation Tool on '15 June 2012' at '14:02:23'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.PrimaryKeys
{
	[Serializable]
	public partial class LocationPrimaryKey : EntityKey<LocationEntity>
	{
		#region Enums

		public enum Field
		{
			LocationID
			, WarehouseID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? locationID;
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
				case Field.LocationID:
					return locationID;
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
				case Field.LocationID:
					return typeof(int?);
				case Field.WarehouseID:
					return typeof(int?);
			}

			return null;
		}

		public override LocationEntity GetBlankEntityWithKey()
		{
			return new LocationEntity()
			{
				locationID = locationID
				, warehouseID = warehouseID
			};
		}

		public override string GetClassName()
		{
			return "LocationPrimaryKey";
		}

		#endregion Overriding / Public Members
	}
}
