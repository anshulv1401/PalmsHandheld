//// Warning: Do not modify!
//// This file (VehicleForHandheldCustomSearchViewUniqueKey.cs) has been auto-generated by PALMS Entity Generation Tool on 'Thursday, February 1, 2018' at '10:56:25 AM'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.CustomSearchViews.UniqueKeys
{
	[Serializable]
	public partial class VehicleForHandheldCustomSearchViewUniqueKey : EntityKey<VehicleForHandheldCustomSearchViewEntity>
	{
		#region Enums

		public enum Field
		{
			VehicleNo
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public string vehicleNo;

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
				case Field.VehicleNo:
					return vehicleNo;
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
				case Field.VehicleNo:
					return typeof(string);
			}

			return null;
		}

		public override VehicleForHandheldCustomSearchViewEntity GetBlankEntityWithKey()
		{
			return new VehicleForHandheldCustomSearchViewEntity()
			{
				vehicleNo = vehicleNo
			};
		}

		public override string GetClassName()
		{
			return "VehicleForHandheldCustomSearchViewUniqueKey";
		}

		#endregion Overriding / Public Members
	}
}
