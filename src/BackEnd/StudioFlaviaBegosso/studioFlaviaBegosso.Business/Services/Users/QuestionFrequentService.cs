using AutoMapper;
using studioFlaviaBegosso.Domain.Dto;
using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using studioFlaviaBegosso.Domain.Interface.Service.Users;
using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Business.Services.Users;

public class QuestionFrequentService : IQuestionFrequentService
{
    private readonly IQuestionFrequentRepository _questionFrequentRepository;
    private readonly IMapper _mapper;

    public QuestionFrequentService(IQuestionFrequentRepository questionFrequentRepository, IMapper mapper)
    {
        _questionFrequentRepository = questionFrequentRepository;
        _mapper = mapper;
    }

    public async Task<List<QuestionFrequentDto>> GetAllQuestionFrequentAsync()
    {
        List<QuestionFrequentModel> model = await _questionFrequentRepository.GetAllQuestionFrequent();
        return _mapper.Map<List<QuestionFrequentDto>>(model);
    }

    public async Task<QuestionFrequentDto> GetQuestionFrequentAsync(Guid id)
    {
        QuestionFrequentModel model = await _questionFrequentRepository.GetQuestionFrequent(id);
        return _mapper.Map<QuestionFrequentDto>(model);
    }
}
