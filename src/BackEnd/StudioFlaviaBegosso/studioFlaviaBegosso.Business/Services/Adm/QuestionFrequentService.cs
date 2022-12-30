using AutoMapper;
using studioFlaviaBegosso.Domain.Dto;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;
using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Business.Services.Adm;

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

    public async Task<bool> InsertQuestionFrequentAsync(QuestionFrequentDto questionFrequent)
    {
        QuestionFrequentModel model = _mapper.Map<QuestionFrequentModel>(questionFrequent);
        return await _questionFrequentRepository.InsertQuestionFrequent(model);
    }

    public async Task<bool> UpdateQuestionFrequentAsync(Guid id, QuestionFrequentDto questionFrequent)
    {
        QuestionFrequentModel model = _mapper.Map<QuestionFrequentModel>(questionFrequent);
        return await _questionFrequentRepository.UpdateQuestionFrequent(id, model);
    }

    public async Task<bool> DeleteQuestionFrequentAsync(Guid id)
    {
        return await _questionFrequentRepository.DeleteQuestionFrequent(id);
    }
}
