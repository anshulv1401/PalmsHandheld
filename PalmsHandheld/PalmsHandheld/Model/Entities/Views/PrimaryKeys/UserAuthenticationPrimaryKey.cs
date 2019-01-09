//// Warning: Do not modify!
//// This file (UserAuthenticationPrimaryKey.cs) has been auto-generated by PALMS Entity Generation Tool on '16 November 2011' at '16:11:39'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.PrimaryKeys
{
	[Serializable]
	public partial class UserAuthenticationPrimaryKey : EntityKey<UserAuthenticationEntity>
	{
		#region Enums

		public enum Field
		{
			PalmsUIElementPath
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public string palmsUIElementPath;

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
				case Field.PalmsUIElementPath:
					return palmsUIElementPath;
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
				case Field.PalmsUIElementPath:
					return typeof(string);
			}

			return null;
		}

		public override UserAuthenticationEntity GetBlankEntityWithKey()
		{
			return new UserAuthenticationEntity()
			{
				palmsUIElementPath = palmsUIElementPath
			};
		}

		public override string GetClassName()
		{
			return "UserAuthenticationPrimaryKey";
		}

		#endregion Overriding / Public Members
	}
}