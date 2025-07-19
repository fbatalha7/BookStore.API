namespace BookStore.Domain.Entities
{
    public class Book
    {
        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int AnoPublicacao { get; private set; }
        public decimal Preco { get; private set; }
        public string Sinopse { get; private set; }
    }
}
