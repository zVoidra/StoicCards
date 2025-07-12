using System.Xml.Linq;

namespace StoicCards.Components.Shared;

internal static class XmlFileManager
{
  private const string DefaultFilePath = @"C:\temp\StoicQuote";

  public static string GenerateXml(List<StoicQuoteModel> stoicQuotes)
  {
    XDocument doc = new XDocument(
      new XElement("StoicQuotes")
      );
    XElement? mainElement = doc.Root;

    if (mainElement == null)
      return string.Empty;

    foreach (StoicQuoteModel stoicQuote in stoicQuotes)
    {
      mainElement.Add(
        new XElement("StoicQuote",
          new XElement("Quote", stoicQuote.Quote),
          new XElement("Author", stoicQuote.Author)
      ));
    }
    return doc.ToString();
  }
}