namespace BookStore.Domain.Entities
{
    public class Book(string title, string author, int yearPublished, decimal price)
    {
        public int Id { get; set; }
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public int YearPublished { get; set; } = yearPublished;
        public decimal Price { get; set; } = price;
    }
}
