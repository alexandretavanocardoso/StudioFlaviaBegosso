using studioFlaviaBegosso.Domain.Dto;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.API.EndPoints.Adm;

[Route("api/v1/adm/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
[Authorize(Policy = "AdminPolicy")]
public class QuestionFrequentController : ControllerBase
{
    private readonly IQuestionFrequentService _questionFrequentService;

    public QuestionFrequentController(IQuestionFrequentService questionFrequentService)
    {
        _questionFrequentService = questionFrequentService;
    }

    [HttpGet("get-list")]
    public async Task<ActionResult<List<QuestionFrequentDto>>> GetAllQuestionFrequent()
        => await _questionFrequentService.GetAllQuestionFrequentAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<QuestionFrequentDto>> GetQuestionFrequent(Guid id)
        => await _questionFrequentService.GetQuestionFrequentAsync(id);

    [HttpPost("insert-question-frequent")]
    public async Task<ActionResult<bool>> InsertQuestionFrequent([FromBody] QuestionFrequentDto questionFrequent)
        => await _questionFrequentService.InsertQuestionFrequentAsync(questionFrequent);

    [HttpPut("update-question-frequent/{id:Guid}")]
    public async Task<ActionResult<bool>> UpdateQuestionFrequent(Guid id, [FromBody] QuestionFrequentDto questionFrequent)
        => await _questionFrequentService.UpdateQuestionFrequentAsync(id, questionFrequent);

    [HttpDelete("delete-question-frequent/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteQuestionFrequent(Guid id)
        => await _questionFrequentService.DeleteQuestionFrequentAsync(id);
}
