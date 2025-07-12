using StoicCards.Models;
using System.Xml.Linq;

namespace StoicCards.Services;

public class XmlService
{
  public string GenerateXml(List<StoicQuoteModel> stoicQuotes)
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
        )
      );
    
    }
    return doc.ToString();
  }
}
