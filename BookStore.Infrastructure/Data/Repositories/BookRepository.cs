using BookStore.Domain.Entities;
using BookStore.Infrastructure.Data.Context;
using BookStore.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Data.Repositories
{
    public class BookRepository(AppDbContext context) : IBookRepository
    {
        private readonly AppDbContext _context = context;

        public async Task<IEnumerable<Book>> GetAsync() =>
            await _context.Books.ToListAsync();
    }
}
