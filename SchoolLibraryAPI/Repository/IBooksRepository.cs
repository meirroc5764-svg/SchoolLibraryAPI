using SchoolLibraryAPI.Model;

namespace SchoolLibraryAPI.Repository
{
    public interface IBooksRepository
    {
        public Task<IEnumerable<Books>> GetAllBooks();
    }
}