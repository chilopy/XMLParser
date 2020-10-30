using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using NVX.RZD.DataModel.Common;


namespace Nvx.Rzd.Entities.CarPassportClasses
{

	public class CarPassportExtended : CarPassport
	{
		protected List<WheelPairs> wheelPairsList;
		protected List<CastPartsOfTruck> castPartsOfTruckList;
		protected bool _isExclusionForCastPartsOfTruck;
		//protected List<CharacteristicOfTrucks> characteristicOfTrucksList;

		[DataMember]
		public override Guid ID
		{
			get { return base.ID;}
			set 
			{
				base.ID = value;
				UpdatePassportID(value);
			}
		}

		[DataMember]
		public override bool? ForReplication
		{
			get { return base.ForReplication; }
			set
			{
				base.ForReplication = value;
				UpdateForReplicationField(value);
			}
		}

		[DataMember]
		public List<WheelPairs> WheelPairsList
		{
			get { return wheelPairsList; }
			set { wheelPairsList = value; }
		}

		[DataMember]
		public List<CastPartsOfTruck> CastPartsOfTruckList
		{
			get { return castPartsOfTruckList; }
			set { castPartsOfTruckList = value; }
		}

		[DataMember]
		public bool IsExclusionForCastPartsOfTruck
		{
			get { return _isExclusionForCastPartsOfTruck; }
			set 
			{ 
				_isExclusionForCastPartsOfTruck = value;
			}
		}

		protected void UpdatePassportID(Guid newID)
		{
			if (wheelPairsList != null)
			{
				foreach (var rec in wheelPairsList)
				{
					rec.PassportID = newID;
				}
			}

			if (castPartsOfTruckList != null)
			{
				foreach (var rec in castPartsOfTruckList)
				{
					rec.PassportID = newID;
				}
			}
		}

		public void ChangeIdsForLists()
		{
			if (wheelPairsList != null)
			{
				foreach (var rec in wheelPairsList)
				{
					rec.RecordID = Guid.NewGuid();
				}
			}

			if (castPartsOfTruckList != null)
			{
				foreach (var rec in castPartsOfTruckList)
				{
					rec.ID = Guid.NewGuid();
				}
			}
		}

		public CarPassport GetCarPassport()
		{
			CarPassport passport = new CarPassport();
			if (ID == Guid.Empty)
			{
				ID = Guid.NewGuid();				
			}
			passport.ID = ID;
			if (this.FillingDate == null)
			{
				this.FillingDate = CommonConstants.RecordLastDate;
			}
			passport.FillingDate = this.FillingDate;
			passport.ForReplication = this.ForReplication;
			passport.DeletingBy = this.DeletingBy;
			passport.DeletingByOrganization = this.DeletingByOrganization;
			if (this.DeletingDate == null)
			{
				this.DeletingDate = CommonConstants.RecordLastDate;
			}
			passport.DeletingDate = this.DeletingDate;
			//TODO: Добавить на этом этапе валидацию, на основе которой будет уст-ся флаг
			//или сделать валидацию на этапе загрузки, а эторт кусок вообще убрать
			if (this.IsValid == null)
			{
				this.IsValid = false;
			}
			passport.IsValid = this.IsValid;
			if (this.IVCJAFileGenerationDate == null)
			{
				this.IVCJAFileGenerationDate = CommonConstants.RecordLastDate;
			}
			passport.IVCJAFileGenerationDate = this.IVCJAFileGenerationDate;
			if (this.AnswerDate == null)
			{
				this.AnswerDate = CommonConstants.RecordLastDate;
			}
			passport.AnswerDate = this.AnswerDate;
			passport.Error = this.Error;
			passport.Status = this.Status;
			if (this.CountWheelPairs == null || this.CountWheelPairs == 0)
			{
				this.CountWheelPairs = wheelPairsList.Count;
			}
			passport.CountWheelPairs = this.CountWheelPairs;
			if (this.CountCastPartsOfTruck == null || this.CountCastPartsOfTruck == 0)
			{
				this.CountCastPartsOfTruck = castPartsOfTruckList.Count;
			}
			passport.CountCastPartsOfTruck = this.CountCastPartsOfTruck;
			passport.CountCharacteristicOfTrucks = 0;
			passport.RecordOwner = this.RecordOwner;
			passport.OwnerOrganization = this.OwnerOrganization;
			passport.WithOutRequest = this.WithOutRequest;
			return passport;
		}

		private void UpdateForReplicationField (bool? value)
		{
			if (wheelPairsList != null)
			{
				foreach (var rec in wheelPairsList)
				{
					rec.ForReplication = value;
				}
			}

			if (castPartsOfTruckList != null)
			{
				foreach (var rec in castPartsOfTruckList)
				{
					rec.ForReplication = value;
				}
			}
		}

		public CarPassportExtended()
		{
			wheelPairsList = new List<WheelPairs>();
			castPartsOfTruckList = new List<CastPartsOfTruck>();

			_isExclusionForCastPartsOfTruck = false;
		}

		/// <summary>
		/// Возвращает пустой ли лист комплектации или нет
		/// </summary>
		/// <returns>true - ЛК пустой, false - ЛК заполнялся<returns>
		public bool IsEmptyPassport()
		{
			bool checkWP = !(WheelPairsList != null && WheelPairsList.Count != 0);
			bool checkCPOT = !(CastPartsOfTruckList != null && CastPartsOfTruckList.Count != 0);
			if (checkWP && checkCPOT)
				return true;
			else
			{
				bool result = true;
				foreach (var rec in this.WheelPairsList)
				{
					if (GetIsEmptyWPRec(rec) == false)
					{
						result = false;
						break;
					}
				}

				if (result == false)
					return result;

				foreach (var rec in this.CastPartsOfTruckList)
				{
					if (GetIsEmptyCPOTRec(rec) == false)
					{
						result = false;
						break;
					}
				}

				return result;

				//foreach (var rec in this.CharacteristicOfTrucksList)
				//{
				//    if (CheckIsEmptyCOTRec(rec) == false)
				//    {
				//        result = false;
				//        break;
				//    }
				//}

				//if (result == false)
				//    return false;
			}
		}

		protected bool GetIsEmptyWPRec(WheelPairs wp)
		{
			if (wp == null)
				return true;
			else
			{
				bool idManufacturerFirmIsEmpty = wp.IdManufacturerFirm.HasValue == false;
				bool firmCompleteSurveyIDIsEmpty = wp.FirmCompleteSurveyID.HasValue == false;
				bool idOwnerIsEmpty = wp.IdOwner.HasValue == false;
				bool rimsThicknessLeftWheelIsEmpty = wp.RimsThicknessLeftWheel.HasValue == false;
				bool rimsThicknessRightWheelIsEmpty = wp.RimsThicknessRightWheel.HasValue == false;
#if SILVERLIGHT
				bool serialNumberOfAxisIsEmpty = String.IsNullOrEmpty(wp.SerialNumberOfAxis) || String.IsNullOrWhiteSpace(wp.SerialNumberOfAxis);
#else
				bool serialNumberOfAxisIsEmpty = String.IsNullOrEmpty(wp.SerialNumberOfAxis);
#endif
				bool yearOfManufactorerIsEmpty = wp.YearOfManufactorer.HasValue == false;
				bool dateInspectionIsEmpty = String.IsNullOrEmpty(wp.DateInspection) || wp.DateInspection == "  .    ";
				bool emptyRec = idManufacturerFirmIsEmpty && idOwnerIsEmpty && rimsThicknessLeftWheelIsEmpty && rimsThicknessRightWheelIsEmpty && serialNumberOfAxisIsEmpty && yearOfManufactorerIsEmpty && firmCompleteSurveyIDIsEmpty && dateInspectionIsEmpty;

				if (emptyRec)
					return true;
				else
					return false;
			}
		}

		protected bool GetIsEmptyCPOTRec(CastPartsOfTruck cpot)
		{
			if (cpot == null)
				return true;
			else
			{
				bool idManufacturerFirmIsEmpty = cpot.IdManufacturerFirm.HasValue == false;
				bool idOwnerIsEmpty = cpot.IdOwner.HasValue == false;
#if SILVERLIGHT
				bool SerialNumberOfPartIsEmpty = String.IsNullOrEmpty(cpot.SerialNumberOfPart) || String.IsNullOrWhiteSpace(cpot.SerialNumberOfPart);
#else
				bool SerialNumberOfPartIsEmpty = String.IsNullOrEmpty(cpot.SerialNumberOfPart);
#endif
				bool yearOfManufactorerIsEmpty = cpot.YearOfManufactorer.HasValue == false;
				bool emptyRec = idManufacturerFirmIsEmpty && idOwnerIsEmpty && SerialNumberOfPartIsEmpty && yearOfManufactorerIsEmpty;
				if (emptyRec)
					return true;
				else
					return false;
			}
		}
	}
}
