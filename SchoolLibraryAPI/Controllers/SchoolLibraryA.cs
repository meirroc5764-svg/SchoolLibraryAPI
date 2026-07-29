using Microsoft.AspNetCore.Mvc;
using SchoolLibraryAPI.Model;
using SchoolLibraryAPI.Repository;

namespace SchoolLibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SchoolLibraryAPI : ControllerBase
{
    private IBooksRepository _booksRepository;
    public SchoolLibraryAPI (IBooksRepository booksRepository)
    {
        _booksRepository = booksRepository;
    }
    [HttpGet]
    public async Task<IEnumerable<Books>> GetAllBooksData()
    {
        var allData= await _booksRepository.GetAllBooks();
        return allData;
    }
}
