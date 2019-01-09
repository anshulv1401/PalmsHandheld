//// Warning: Do not modify!
//// This file (PackTypeUniqueKey_Name.cs) has been auto-generated by PALMS Entity Generation Tool on '05 October 2012' at '15:19:38'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.UniqueKeys
{
	[Serializable]
	public partial class PackTypeUniqueKey_Name : EntityKey<PackTypeEntity>
	{
		#region Enums

		public enum Field
		{
			PackTypeName
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public string packTypeName;

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
				case Field.PackTypeName:
					return packTypeName;
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
				case Field.PackTypeName:
					return typeof(string);
			}

			return null;
		}

		public override PackTypeEntity GetBlankEntityWithKey()
		{
			return new PackTypeEntity()
			{
				packTypeName = packTypeName
			};
		}

		public override string GetClassName()
		{
			return "PackTypeUniqueKey_Name";
		}

		#endregion Overriding / Public Members
	}
}
