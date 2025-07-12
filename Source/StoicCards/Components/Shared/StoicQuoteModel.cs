namespace StoicCards.Components.Shared;

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
