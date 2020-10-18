using System.Xml.Linq;

public class KolesnayaPara:Item{
    public const string XML_TYPE_NAME = "Колёсная пара";

    public override void FillItem(XElement blk){
    if (blk.Element("Position") != null) this.Position = blk.Element("Position").Value;
    if (blk.Element("Number") != null) this.Number = blk.Element("Number").Value;
    if (blk.Element("CreateDate") != null) this.Year = blk.Element("DateCreate").Value;
    if (blk.Element("FactoryId") != null) this.FactoryId = blk.Element("FactoryId").Value;
 }
}