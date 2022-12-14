using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Domain.Interface.Service;

namespace StudioFlaviaBegosso.Business.Services;

public class QuestionFrequentService : IQuestionFrequentService
{
    private readonly IQuestionFrequentRepository _questionFrequentRepository;

    public QuestionFrequentService(IQuestionFrequentRepository questionFrequentRepository)
    {
        _questionFrequentRepository = questionFrequentRepository;
    }
}
