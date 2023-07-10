using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BooksApi.Models;
using BooksApi.Data;

namespace BooksApi.Controllers
{
    [Route("api/v1/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksDbContext _context;

        public BooksController(BooksDbContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Books>>> GetBooks([FromQuery] Books searchBook)
        {

            IQueryable<Books> query = _context.Books;

            if (searchBook.AuthorId != Guid.Empty)
                query = query.Where(book => book.AuthorId == searchBook.AuthorId);

            if (!string.IsNullOrEmpty(searchBook.Isbn))
                query = query.Where(book => book.Isbn == searchBook.Isbn);

            if (!string.IsNullOrEmpty(searchBook.Category))
                query = query.Where(book => book.Category == searchBook.Category);

            return await query.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Books>> GetBooksModel(Guid id)
        {
          if (_context.Books == null)
          {
              return NotFound();
          }
            var booksModel = await _context.Books.FindAsync(id);

            if (booksModel == null)
            {
                return NotFound();
            }

            return booksModel;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooksModel(Guid id, Books booksModel)
        {
            if (id != booksModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(booksModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BooksModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Books>> PostBooksModel(Books booksModel)
        {
          if (_context.Books == null)
          {
              return Problem("Entity set 'BooksDbContext.BooksModels'  is null.");
          }
            _context.Books.Add(booksModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBooksModel", new { id = booksModel.Id }, booksModel);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooksModel(Guid id)
        {
            if (_context.Books == null)
            {
                return NotFound();
            }
            var booksModel = await _context.Books.FindAsync(id);
            if (booksModel == null)
            {
                return NotFound();
            }

            _context.Books.Remove(booksModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BooksModelExists(Guid id)
        {
            return (_context.Books?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
