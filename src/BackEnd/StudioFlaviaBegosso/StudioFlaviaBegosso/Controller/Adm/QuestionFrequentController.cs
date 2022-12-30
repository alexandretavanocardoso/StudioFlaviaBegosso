using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.API.EndPoints.Adm;

[Route("api/v1/adm/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
[Authorize(Policy = "AdminPolicy")]
public class QuestionFrequentController : ControllerBase
{
    private readonly IQuestionFrequentService _questionFrequentService;

    public QuestionFrequentController(IQuestionFrequentService questionFrequentService) {
        _questionFrequentService = questionFrequentService;
    }

    [HttpGet("get-list")]
    public IEnumerable<string> getAllQuestionFrequent()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("get/{id:Guid}")]
    public string GetQuestionFrequent(Guid id)
    {
        return "value";
    }

    [HttpPost("insert-question-frequent")]
    public void InsertQuestionFrequent([FromBody] string value)
    {
    }

    [HttpPut("update-question-frequent/{id:Guid}")]
    public void UpdateQuestionFrequent(Guid id, [FromBody] string value)
    {
    }

    [HttpDelete("delete-question-frequent/{id:Guid}")]
    public void DeleteQuestionFrequent(Guid id)
    {
    }
}
