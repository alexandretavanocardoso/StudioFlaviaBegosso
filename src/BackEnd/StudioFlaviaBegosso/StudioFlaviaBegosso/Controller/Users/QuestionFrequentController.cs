using Microsoft.AspNetCore.Mvc;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace StudioFlaviaBegosso.API.EndPoints.Users;

[Route("api/user/[controller]")]
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
}
