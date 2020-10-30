using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Nvx.Rzd.Entities.Enumerations
{
	[DataContract]
	public enum NameOfPartOfTruck
	{
		[EnumMember]
		[Description("Надрессорная балка")]
		Joist = 0,
		[EnumMember]
		[Description("Боковая рама")]
		TheSideFrame = 1
	}

	public static class NameOfPartOfTruckExtensions
	{
		public static string Title(this NameOfPartOfTruck val)
		{
			DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
			return attributes.Length > 0 ? attributes[0].Description : String.Empty;
		}
	}
}
