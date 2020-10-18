using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

public class CarParser
{

       public static List<Passport> ParseCars(string xmlString)
        {
            XDocument doc = null;
            try
            {
                doc = XDocument.Parse(xmlString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            List<XElement> cars = doc.Root.Elements("Car").ToList();
            List<Passport> carslist = new List<Passport>();
            if ((cars != null) && (cars.Count > 0))
            {
                foreach (var car in cars)
                {
                    Passport newCar = new Passport();
                    if (car.Attribute("Number") != null)
                    {
                        newCar.Number = car.Attribute("Number").Value;
                    }
                    ParseCarItem(car, newCar, BalkaNadressornaya.XML_TYPE_NAME);
                    ParseCarItem(car, newCar, KolesnayaPara.XML_TYPE_NAME);
                    ParseCarItem(car, newCar, RamaBokovaya.XML_TYPE_NAME);
                    carslist.Add(newCar);

                }

            }
            else
            {
                Console.WriteLine("cars not found");
            }
            return carslist;
        }

        private static Passport ParseCarItem(XElement car, Passport newCar, string itemType)
        {
            IEnumerable<XElement> items = car.Descendants("Item")
                                    .Where(item => (item.Element("Component") != null) && (item.Element("Component").Value == itemType));

            if (items != null)
            {
                foreach (var blk in items)
                {

                    Item itm = ItemHelper.CreateItem(itemType);
                    itm.FillItem(blk);

                    ItemHelper.AddItemToCar(itm,newCar);

                }
           
            }
            else
            {
                Console.WriteLine("items not found");
            }
            return newCar;
    }
 }
