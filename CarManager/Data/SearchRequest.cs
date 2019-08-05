namespace CarManager.Data
{
    public class SearchRequest
    {
        public string Term { get; set; }
        public SearchRequest( string term)
        {
            Term = term;
        }
    }
}
