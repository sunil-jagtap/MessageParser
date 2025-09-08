namespace FileParser.Models
{
    public class ParsedMessage
    {
        public int SequenceNumber { get; set; }
        public required string Message { get; set; }
    }
}