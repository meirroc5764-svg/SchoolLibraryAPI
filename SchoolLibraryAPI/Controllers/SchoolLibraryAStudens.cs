using Microsoft.AspNetCore.Mvc;
using SchoolLibraryAPI.Model;
using SchoolLibraryAPI.Repository;

namespace SchoolLibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SchoolLibraryAPIStudens : ControllerBase
{
    private IStudensRepository _studensRepository;
    public SchoolLibraryAPIStudens(IStudensRepository studensRepository)
    {
        _studensRepository = studensRepository;
    }
    [HttpGet]
    public async Task<IEnumerable<Studens>> GetAllStudensData()
    {
        var allDataStudens = await _studensRepository.GetAllStudens();
        return allDataStudens;
    }
}