using System.Collections.Generic;
using System.Linq;

namespace hw
{
    public class mod : i_model
    {
        private AuthorsBooksDbContext _context;

        public mod()
        {
            _context = new AuthorsBooksDbContext();
        }

        public void set_file_path(string path)
        {
            
        }

        public void load_data()
        {
        }

        public void save_data()
        {
            _context.SaveChanges();
        }

        public List<string> get_authors()
        {
            return _context.Authors
                .Select(a => a.Name)
                .ToList();
        }

        public List<string> get_books_by_author(string author_name)
        {
            var author = _context.Authors
                .Where(a => a.Name == author_name)
                .FirstOrDefault();

            if (author != null)
            {
                return author.Books
                    .Select(b => b.Title)
                    .ToList();
            }

            return new List<string>();
        }

        public List<string> get_all_books()
        {
            return _context.Books
                .Select(b => b.Title)
                .ToList();
        }

        public void add_author(string name)
        {
            var newAuthor = new Author
            {
                Name = name
            };

            _context.Authors.Add(newAuthor);
            _context.SaveChanges();
        }

        public void delete_author(string name)
        {
            var author = _context.Authors
                .FirstOrDefault(a => a.Name == name);

            if (author != null)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
            }
        }

        public void edit_author(string old_name, string new_name)
        {
            var author = _context.Authors
                .FirstOrDefault(a => a.Name == old_name);

            if (author != null)
            {
                author.Name = new_name;
                _context.SaveChanges();
            }
        }

        public void add_book(string author_name, string book_title)
        {
            var author = _context.Authors
                .FirstOrDefault(a => a.Name == author_name);

            if (author != null)
            {
                var newBook = new Book
                {
                    Title = book_title,
                    AuthorId = author.AuthorId
                };

                _context.Books.Add(newBook);
                _context.SaveChanges();
            }
        }

        public void delete_book(string author_name, string book_title)
        {
            var author = _context.Authors
                .FirstOrDefault(a => a.Name == author_name);

            if (author != null)
            {
                var book = _context.Books
                    .FirstOrDefault(b => b.Title == book_title 
                                      && b.AuthorId == author.AuthorId);

                if (book != null)
                {
                    _context.Books.Remove(book);
                    _context.SaveChanges();
                }
            }
        }

        public void edit_book(string author_name, string old_title, string new_title)
        {
            var author = _context.Authors
                .FirstOrDefault(a => a.Name == author_name);

            if (author != null)
            {
                var book = _context.Books
                    .FirstOrDefault(b => b.Title == old_title
                                      && b.AuthorId == author.AuthorId);

                if (book != null)
                {
                    book.Title = new_title;
                    _context.SaveChanges();
                }
            }
        }
    }
}
