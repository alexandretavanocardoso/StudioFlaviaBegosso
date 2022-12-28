using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace studioFlaviaBegosso.Business.Services.Users;

public class QuestionFrequentService : IQuestionFrequentService
{
    private readonly IQuestionFrequentRepository _questionFrequentRepository;

    public QuestionFrequentService(IQuestionFrequentRepository questionFrequentRepository)
    {
        _questionFrequentRepository = questionFrequentRepository;
    }
}
