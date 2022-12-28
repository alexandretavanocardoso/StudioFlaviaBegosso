using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Business.Services.Adm;

public class QuestionFrequentService : IQuestionFrequentService
{
    private readonly IQuestionFrequentRepository _questionFrequentRepository;

    public QuestionFrequentService(IQuestionFrequentRepository questionFrequentRepository)
    {
        _questionFrequentRepository = questionFrequentRepository;
    }
}
