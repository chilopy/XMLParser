using System.Xml.Linq;

public class KolesnayaPara : Item
{
    public const string XML_TYPE_NAME = "Колёсная пара";
    public string DateInspection;
    public string firmCompleteSurveyID;
    public string rimsThicknessRightWheel;
    public string rimsThicknessLeftWheel;

    public override void FillItem(XElement blk)
    {
        if (blk.Element("Position") != null) this.Position = blk.Element("Position").Value;
        if (blk.Element("Number") != null) this.Number = blk.Element("Number").Value;
        if (blk.Element("CreateDate") != null) this.Year = blk.Element("DateCreate").Value;
        if (blk.Element("FactoryId") != null) this.FactoryId = blk.Element("FactoryId").Value;
        if (blk.Element("DateExam") != null) this.DateInspection = blk.Element("DateExam").Value;
        if (blk.Element("FactoryExamId") != null) this.firmCompleteSurveyID = blk.Element("FactoryExamId").Value;
        if (blk.Element("AdditionalAttributeValue") != null)
        {
            string attr = blk.Element("AdditionalAttributeValue").Value;
            this.rimsThicknessLeftWheel = attr.Substring(0, (attr.IndexOf("\\"))).Trim();
            this.rimsThicknessRightWheel = attr.Substring((attr.IndexOf("\\"))).Trim();
        }

    }
}