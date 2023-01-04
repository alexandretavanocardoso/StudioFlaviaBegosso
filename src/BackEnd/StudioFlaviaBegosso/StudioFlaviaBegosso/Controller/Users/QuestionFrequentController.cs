using studioFlaviaBegosso.Domain.Dto;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace StudioFlaviaBegosso.API.EndPoints.Users;

[Route("api/v1/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
public class QuestionFrequentController : ControllerBase
{
    private readonly IQuestionFrequentService _questionFrequentService;

    public QuestionFrequentController(IQuestionFrequentService questionFrequentService) {
        _questionFrequentService = questionFrequentService;
    }

    [HttpGet("get-all")]
    public async Task<ActionResult<List<QuestionFrequentDto>>> GetAllQuestionFrequent()
        => await _questionFrequentService.GetAllQuestionFrequentAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<QuestionFrequentDto>> GetQuestionFrequent(Guid id)
        => await _questionFrequentService.GetQuestionFrequentAsync(id);
}
