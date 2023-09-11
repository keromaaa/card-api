namespace CardDetailsAPI.Models
{
    public class CardDetails
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public string ExpiryDate { get; set; }
        public int Ccv { get; set; }
    }
}
