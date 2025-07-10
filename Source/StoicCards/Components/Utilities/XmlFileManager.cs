using System.Xml.Linq;

namespace StoicCards.Components.Utilities;

internal static class XmlFileManager
{
  private const string DefaultFilePath = @"C:\temp\StoicQuote";

  public static string GenerateXml(string quote, string author)
  {
    XDocument doc = new XDocument(
      new XElement("StoicQuote",
        new XElement("Quote", quote),
        new XElement("Author", author)
      )
    );

    return doc.ToString();

    //doc.Save(DefaultFilePath + DateTime.Now.ToString("_yyyy-mm-dd_HH-mm-ss") + ".xml");
  }
}
