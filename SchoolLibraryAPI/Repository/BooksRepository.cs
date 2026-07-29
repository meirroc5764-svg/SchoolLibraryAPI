using SchoolLibraryAPI.Model;
using SchoolLibraryAPI.Enums;

namespace SchoolLibraryAPI.Repository
{
    public class BooksRepository : IBooksRepository
    {
        private List<Books> _booksData = new()
        {

            new Books
            {
                Id = 1,
                Title = "Title",
                Autor = "me",
                Genre = Genres.Fiction,
                years = 1001
            },

            new Books
            {
                Id = 2,
                Title = "Title",
                Autor = "me",
                Genre = Genres.Fiction,
                years = 1001
            }
        };

        public async Task<IEnumerable<Books>> GetAllBooks()
        {
            await Task.Delay(10);
            return _booksData;
        }
    }
}