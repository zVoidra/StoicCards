namespace StoicCards.Models;

public class StoicQuoteModel
{
  public string Quote { get; set; }
  public string Author { get; set; }

  public StoicQuoteModel(string quote, string author)
  {
    Quote = quote;
    Author = author;
  }
}
