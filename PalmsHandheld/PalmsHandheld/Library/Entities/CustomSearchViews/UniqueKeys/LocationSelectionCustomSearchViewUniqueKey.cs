//// Warning: Do not modify!
//// This file (LocationSelectionCustomSearchViewUniqueKey.cs) has been auto-generated by PALMS Entity Generation Tool on 'Monday, August 29, 2016' at '9:23:57 AM'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.CustomSearchViews.UniqueKeys
{
	[Serializable]
	public partial class LocationSelectionCustomSearchViewUniqueKey : EntityKey<LocationSelectionCustomSearchViewEntity>
	{
		#region Enums

		public enum Field
		{
			WarehouseID
			, LocationID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? warehouseID;
		public int? locationID;

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
				case Field.WarehouseID:
					return warehouseID;
				case Field.LocationID:
					return locationID;
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
				case Field.WarehouseID:
					return typeof(int?);
				case Field.LocationID:
					return typeof(int?);
			}

			return null;
		}

		public override LocationSelectionCustomSearchViewEntity GetBlankEntityWithKey()
		{
			return new LocationSelectionCustomSearchViewEntity()
			{
				warehouseID = warehouseID
				, locationID = locationID
			};
		}

		public override string GetClassName()
		{
			return "LocationSelectionCustomSearchViewUniqueKey";
		}

		#endregion Overriding / Public Members
	}
}
