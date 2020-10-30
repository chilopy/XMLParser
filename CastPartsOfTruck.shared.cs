using System;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using Nvx.Rzd.Entities.Enumerations;

namespace Nvx.Rzd.Entities
{
	#if !SILVERLIGHT
	[Serializable]
	#endif
	[DataContract]
	public class CastPartsOfTruck : INotifyPropertyChanged
	{
		private Guid? id;

		private Guid? passportID;

		private int? serialNumber;

		private NameOfPartOfTruck nameOfPartTruck;

		private PlaceUnderVirtualcar placeUnderVirtualCar;

		private int? idOwner;

		private int? idManufacturerFirm;

		private string serialNumberOfAxis;

		private int? yearOfManufactorer;

		private bool? forReplication;

		private int orderInFile;

		[DataMember]
		public virtual Guid? ID
		{
			get { return id; }
			set
			{
				id = value;
				NotifyPropertyChanged("ID");
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
		public virtual NameOfPartOfTruck NameOfPartTruck
		{
			get { return nameOfPartTruck; }
			set
			{
				nameOfPartTruck = value;
				NotifyPropertyChanged("NameOfPartTruck");
			}
		}

		[DataMember]
		public virtual int? SerialNumber
		{
			get { return serialNumber; }
			set
			{
				serialNumber = value;
				NotifyPropertyChanged("SerialNumber");
			}
		}

		[DataMember]
		public virtual PlaceUnderVirtualcar PlaceUnderVirtualCar
		{
			get { return placeUnderVirtualCar; }
			set
			{
				placeUnderVirtualCar = value;
				NotifyPropertyChanged("PlaceUnderVirtualCar");
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
		public virtual string SerialNumberOfPart
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
		public virtual int OrderInFile
		{
			get { return orderInFile; }
			set
			{
				orderInFile = value;
				NotifyPropertyChanged("OrderInFile");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public class CastPartsOfTruckCompare : IComparer<CastPartsOfTruck>
	{
		public int Compare(CastPartsOfTruck x, CastPartsOfTruck y)
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
					if (x.SerialNumber == null)
					{
						if (y.SerialNumber == null)
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
						if (y.SerialNumber == null)
						{
							return 1;
						}
						else
						{
							int xs = (int)x.SerialNumber;
							int ys = (int)y.SerialNumber;

							int retval = xs.CompareTo(ys);

							if (retval != 0)
							{
								return retval;
							}
							else
							{
								if (x.PlaceUnderVirtualCar == PlaceUnderVirtualcar.Joist && y.PlaceUnderVirtualCar != PlaceUnderVirtualcar.Joist)
									return -1;
								else if (y.PlaceUnderVirtualCar == PlaceUnderVirtualcar.Joist && x.PlaceUnderVirtualCar != PlaceUnderVirtualcar.Joist)
									return 1;
								else if (x.PlaceUnderVirtualCar == PlaceUnderVirtualcar.Left && y.PlaceUnderVirtualCar == PlaceUnderVirtualcar.Right)
								{
									if (x.OrderInFile < y.OrderInFile)
										return 1;
									else
										return -1;
								}
								else if (y.PlaceUnderVirtualCar == PlaceUnderVirtualcar.Left && x.PlaceUnderVirtualCar == PlaceUnderVirtualcar.Right)
								{
									if (x.OrderInFile > y.OrderInFile)
										return -1;
									else
										return 1;
								}
								else 
								{
									if (x.OrderInFile > y.OrderInFile)
										return -1;
									else if (x.OrderInFile < y.OrderInFile)
										return 1;
									else 
										return 0;
								}
								//else
								//    return 0;
							}
						}
					}
				}
			}
		}
	}
}
