using SchoolLibraryAPI.Model;
using SchoolLibraryAPI.Enums;

namespace SchoolLibraryAPI.Repository
{
    public class StudensRepository : IStudensRepository
    {
        private List<Studens> _studensdata = new()
        {

            new Studens
            {
                Id = 1,
                Name = "Meir",
                Grade = 11,
                BookId = 1,
                BorrowDate = DateTime.Now,


            },

            new Studens
            {
                Id = 2,
                Name = "Meir",
                Grade = 11,
                BookId = 1,
                BorrowDate = DateTime.Now,

            }
        };

        public async Task<IEnumerable<Studens>> GetAllStudens()
        {
            await Task.Delay(10);
            return _studensdata;
        }
    }
}