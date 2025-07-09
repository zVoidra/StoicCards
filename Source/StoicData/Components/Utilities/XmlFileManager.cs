using System.Xml.Linq;

namespace StoicData.Components.Utilities;

internal static class XmlFileManager
{
  private const string DefaultFilePath = @"C:\temp\StoicQuote";

  public static void SaveToXml(string quote, string author)
  {
    XDocument doc = new XDocument(
      new XElement("StoicQuote",
        new XElement("Quote", quote),
        new XElement("Author", author)
      )
    );

    if (Directory.Exists(Path.GetDirectoryName(DefaultFilePath)) == false)
    {
      Directory.CreateDirectory(Path.GetDirectoryName(DefaultFilePath));
    }

    doc.Save(DefaultFilePath + DateTime.Now.ToString("_yyyy-mm-dd_HH-mm-ss") + ".xml");
  }
}
