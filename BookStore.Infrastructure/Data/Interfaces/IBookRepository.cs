using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Data.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAsync();
    }
}
