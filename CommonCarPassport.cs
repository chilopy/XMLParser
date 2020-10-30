using System;
using System.Runtime.Serialization;
using Nvx.Rzd.Entities.Enumerations;

namespace Nvx.Rzd.Entities.CarPassportClasses
{

	public class CommonCarPassport
	{
		[DataMember]
		public virtual Guid ID { get; set; }

		[DataMember]
		public virtual DateTime? IVCJAFileGenerationDate { get; set; }

		[DataMember]
		public virtual DateTime? FillingDate { get; set; }

		[DataMember]
		public virtual int? Status { get; set; }

		[DataMember]
		public virtual bool? IsValid { get; set; }

		[DataMember]
		public virtual int? CountWheelPairs { get; set; }

		[DataMember]
		public virtual int? CountCastPartsOfTruck { get; set; }

		[DataMember]
		public virtual int? CountCharacteristicOfTrucks { get; set; }

		[DataMember]
		public virtual bool? ForReplication { get; set; }

		[DataMember]
		public virtual string RecordOwner { get; set; }

		[DataMember]
		public virtual Guid? OwnerOrganization { get; set; }

		[DataMember]
		public virtual bool? WithOutRequest { get; set; }

		[DataMember]
		public virtual DateTime? AnswerDate { get; set; }

		[DataMember]
		public virtual string Error { get; set; }

		[DataMember]
		public virtual DateTime? DeletingDate { get; set; }

		[DataMember]
		public virtual string DeletingBy { get; set; }

		[DataMember]
		public virtual Guid? DeletingByOrganization { get; set; }
	}
}
