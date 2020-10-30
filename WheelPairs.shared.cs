using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Nvx.Rzd.Entities
{
	
	public class WheelPairs : INotifyPropertyChanged
	{
		private Guid? recordID;

		private Guid? passportID;

		private int? serialNumberUnderVirtualCar;

		private int? idOwner;

		//private DateTime? dateInspection;

		private int? idManufacturerFirm;

		private string serialNumberOfAxis;

		private int? yearOfManufactorer;

		private float? rimsThicknessRightWheel;

		private float? rimsThicknessLeftWheel;

		private bool? forReplication;

		private int? firmCompleteSurveyID;

		private string dateInspection;


		[DataMember]
		public virtual Guid? RecordID 
		{ 
			get {return recordID;} 
			set 
			{
				recordID = value;
				NotifyPropertyChanged("RecordID");
			}
		}

		[DataMember]
		public virtual Guid? PassportID
		{
			get { return passportID; }
			set
			{
				passportID = value;
				NotifyPropertyChanged("PassportID");
			}
		}

		[DataMember]
		public virtual int? SerialNumberUnderVirtualCar 
		{
			get { return serialNumberUnderVirtualCar; }
			set
			{
				serialNumberUnderVirtualCar = value;
				NotifyPropertyChanged("SerialNumberUnderVirtualCar");
			}
		}

		[DataMember]
		public virtual int? IdOwner 
		{
			get { return idOwner; } 
			set 
			{
				idOwner = value;
				NotifyPropertyChanged("IdOwner");
			} 
		}

		[DataMember]
		public virtual int? IdManufacturerFirm 
		{
			get { return idManufacturerFirm; }
			set
			{
				idManufacturerFirm = value;
				NotifyPropertyChanged("IdManufacturerFirm");
			}
		}

		[DataMember]
		public virtual string SerialNumberOfAxis 
		{
			get { return serialNumberOfAxis; } 
			set 
			{
				serialNumberOfAxis = value;
				NotifyPropertyChanged("SerialNumberOfAxis");
			} 
		}

		[DataMember]
		public virtual int? YearOfManufactorer 
		{
			get { return yearOfManufactorer; }
			set
			{
				yearOfManufactorer = value;
				NotifyPropertyChanged("YearOfManufactorer");
			}
		}

		[DataMember]
		public virtual float? RimsThicknessRightWheel 
		{
			get { return rimsThicknessRightWheel; } 
			set
			{
				rimsThicknessRightWheel = value;
				NotifyPropertyChanged("RimsThicknessRightWheel");
			} 
		}

		[DataMember]
		public virtual float? RimsThicknessLeftWheel 
		{
			get { return rimsThicknessLeftWheel; }
			set
			{
				rimsThicknessLeftWheel = value;
				NotifyPropertyChanged("RimsThicknessLeftWheel");
			}
		}

		[DataMember]
		public bool? ForReplication
		{
			get { return forReplication; }
			set 
			{ 
				forReplication = value;
				NotifyPropertyChanged("ForReplication");
			}
		}

		[DataMember]
		public int? FirmCompleteSurveyID
		{
			get { return firmCompleteSurveyID; }
			set 
			{ 
				firmCompleteSurveyID = value;
				NotifyPropertyChanged("FirmCompleteSurveyID");
			}
		}

		[DataMember]
		public string DateInspection
		{
			get { return dateInspection; }
			set 
			{ 
				dateInspection = value;
				NotifyPropertyChanged("DateInspection");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged!=null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}


	public class WheelPairCompare : IComparer<WheelPairs>
	{
		public int Compare(WheelPairs x, WheelPairs y)
		{
			if (x == null)
			{
				if (y == null)
				{
					return 0;
				}
				else
				{
					return -1;
				}
			}
			else
			{
				if (y == null)
				{
					return 1;
				}
				else
				{
					if (x.SerialNumberUnderVirtualCar == null)
					{
						if (y.SerialNumberUnderVirtualCar == null)
						{
							return 0;
						}
						else
						{
							return -1;
						}
					}
					else
					{
						if (y.SerialNumberUnderVirtualCar == null)
						{
							return 1;
						}
						else
						{
							int xs = (int)x.SerialNumberUnderVirtualCar;
							int ys = (int)y.SerialNumberUnderVirtualCar;

							int retval = xs.CompareTo(ys);

							if (retval != 0)
							{
								return retval;
							}
							else
							{
								return 0;
							}
						}
					}
				}
			}
		}
	}
}
