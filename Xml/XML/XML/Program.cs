using System;
using System.Xml;

class Program
{
    static void Main()
    {
        XmlDocument xmlDocument = new XmlDocument();

        XmlElement rootNode = xmlDocument.CreateElement("Mektebler");
        xmlDocument.AppendChild(rootNode);

        XmlElement mektebNode1 = xmlDocument.CreateElement("Mekteb");
        rootNode.AppendChild(mektebNode1);

        XmlElement adNode1 = xmlDocument.CreateElement("Ad");
        adNode1.InnerText = "ADHU";
        mektebNode1.AppendChild(adNode1);

        XmlElement dirrectorrNode1 = xmlDocument.CreateElement("Director");
        dirrectorrNode1.InnerText = "Keramet Boyukchol";
        mektebNode1.AppendChild(dirrectorrNode1);

        Console.WriteLine(xmlDocument.InnerXml);
    }
}
