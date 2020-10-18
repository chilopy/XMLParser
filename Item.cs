using System.Xml.Linq;
public class Item{
    public string Position{get;set;}
    public string Number{get;set;}
    public string Year{get;set;}
    public string FactoryId{get;set;}
 public virtual void FillItem(XElement blk){
    if (blk.Element("Position") != null) this.Position = blk.Element("Position").Value;
    if (blk.Element("Number") != null) this.Number = blk.Element("Number").Value;
    if (blk.Element("Year") != null) this.Year = blk.Element("Year").Value;
    if (blk.Element("FactoryId") != null) this.FactoryId = blk.Element("FactoryId").Value;
 }
}