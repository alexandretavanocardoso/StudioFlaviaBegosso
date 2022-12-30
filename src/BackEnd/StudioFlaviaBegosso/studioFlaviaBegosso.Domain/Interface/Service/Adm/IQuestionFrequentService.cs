using studioFlaviaBegosso.Domain.Dto;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Adm;

public interface IQuestionFrequentService {
    Task<List<QuestionFrequentDto>> GetAllQuestionFrequentAsync();
    Task<QuestionFrequentDto> GetQuestionFrequentAsync(Guid id);
    Task<bool> InsertQuestionFrequentAsync(QuestionFrequentDto questionFrequent);
    Task<bool> UpdateQuestionFrequentAsync(Guid id, QuestionFrequentDto questionFrequent);
    Task<bool> DeleteQuestionFrequentAsync(Guid id);
}
