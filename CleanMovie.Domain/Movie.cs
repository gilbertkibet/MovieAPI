namespace CleanMovie.Domain
{
    public class Movie
    {
        public Guid Id { get; set; }=Guid.NewGuid();

        public string Name { get; set; } = string.Empty;

        public decimal Cost { get; set; }   
    }
}