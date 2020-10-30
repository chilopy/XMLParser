using System;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Nvx.Rzd.Entities.Enumerations
{
	[DataContract]
	public enum PlaceUnderVirtualcar
	{
		[EnumMember]
		[Description("Нет")]
		Joist=0,
		[EnumMember]
		[Description("Левая")]
		Left=1,
		[EnumMember]
		[Description("Правая")]
		Right=2
	}

	public static class PlaceUnderVirtualcarExtensions
	{
		public static string Title(this PlaceUnderVirtualcar val)
		{
			DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
			return attributes.Length > 0 ? attributes[0].Description : String.Empty;
		}
	}
}
