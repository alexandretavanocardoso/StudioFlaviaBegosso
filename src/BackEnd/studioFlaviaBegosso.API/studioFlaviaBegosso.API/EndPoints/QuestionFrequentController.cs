using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service;

namespace StudioFlaviaBegosso.API.EndPoints.Blog;

[Route("api/[controller]")]
[ApiController]
public class QuestionFrequentController : ControllerBase
{
    private readonly IQuestionFrequentService _questionFrequentService;

    public QuestionFrequentController(IQuestionFrequentService questionFrequentService) {
        _questionFrequentService = questionFrequentService;
    }

    [HttpGet("get-all-question-frequent")]
    public IEnumerable<string> getAllQuestionFrequent()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("get-question-frequent/{id:Guid}")]
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
