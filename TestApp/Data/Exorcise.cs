namespace TestApp.Data
{
    public class Exorcise
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required int GroupId { get; set; }
        public required DateTime Date { get; set; }
        public required bool Rounds { get; set; }
        public string? Time { get; set; }
        public byte[]? Image { get; set; }
    }
}
