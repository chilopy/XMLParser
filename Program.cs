using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

namespace xml_parse
{
    class TestXML
    {
        static void Main(string[] args)
        {
            var xmlFilePath = @"XMLFile2.xml";
            String xmlString = string.Empty;
            try
            {
                xmlString = System.IO.File.ReadAllText(xmlFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            var CarsPassport = CarParser.ParseCars(xmlString);
        }

    } 
}
