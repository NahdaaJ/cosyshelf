using CosyShelf.Core.Models;
using CosyShelf.Data.Entities;
using CosyShelf.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosyShelf.Data.Services
{
    public class BookService
    {
        public readonly IRepository<BookEntity> _repository;

        public BookService(IRepository<BookEntity> repository)
        {
            _repository = repository;
        }

        public async Task<BookEntity?> GetBookByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Select(MapToModel).ToList();
        }

        public async Task AddBookAsync(Book book)
        {
            var entity = MapToEntity(book);
            await _repository.AddAsync(entity);
        }

        public async Task UpdateBookAsync(Book book)
        {
            var entity = MapToEntity(book);
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteBookAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        //private Book MapToModel(BookEntity book) => new Book
        //{
        //    Id = book.Id,
        //    Title = book.Title,
        //    Author = book.Author,
        //    Description = book.Description,
        //    Rating = book.Rating,
        //    Comment = book.Comment,
        //    Status = (Core.Enums.BookStatus)book.Status,
        //};

        private Book MapToModel(BookEntity bookEntity)
        {
            var book = new Book(bookEntity.Title, bookEntity.Author)
            {
                Id = bookEntity.Id,
                Description = bookEntity.Description,
                Rating = bookEntity.Rating,
                Comment = bookEntity.Comment,
                Status = (Core.Enums.BookStatus)bookEntity.Status
            };
            return book;
        }
        private BookEntity MapToEntity(Book book) => new BookEntity
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            Description = book.Description,
            Rating = book.Rating,
            Comment = book.Comment,
            Status = (int)book.Status,
        };
    }
}
