using AutoMapper;
using BookStore.Application.DTO;
using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;
using BookStore.Infrastructure.Data.Interfaces;

namespace BookStore.Application.Services
{
    public class BookService(IBookRepository bookRepository, IMapper mapper) : IBookService
    {
        private readonly IBookRepository bookRepository = bookRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<IEnumerable<BookDTO>> GetAsync()
        {
            var books = await bookRepository.GetAsync();

            if (books == null || !books.Any())
                return [];

            return _mapper.Map<IEnumerable<BookDTO>>(books);
        }
    }
}
