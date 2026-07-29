using SchoolLibraryAPI.Model;

namespace SchoolLibraryAPI.Repository
{
    public interface IStudensRepository
    {
        public Task<IEnumerable<Studens>> GetAllStudens();
    }
}