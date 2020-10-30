
using NVX.RZD.DataModel.Common;
using Nvx.Rzd.Entities.CarPassportClasses;
using System.Collections.Generic;
using Nvx.Rzd.Entities;
public static class CarsConverter{


public static CarPassportExtended convert(Passport mpass){
    CarPassportExtended result = new CarPassportExtended();
    foreach (KolesnayaPara mpara in mpass.KolesnayaPara)
    {
        WheelPairs pairs = new WheelPairs();
        
    }
    //mpass.KolesnayaPara
    return result;
}


}