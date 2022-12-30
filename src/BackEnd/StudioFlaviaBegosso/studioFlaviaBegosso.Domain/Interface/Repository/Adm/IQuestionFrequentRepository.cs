using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Domain.Interface.Repository.Adm;

public interface IQuestionFrequentRepository
{
    Task<List<QuestionFrequentModel>> GetAllQuestionFrequent();
    Task<QuestionFrequentModel> GetQuestionFrequent(Guid id);
    Task<bool> InsertQuestionFrequent(QuestionFrequentModel questionFrequent);
    Task<bool> UpdateQuestionFrequent(Guid id, QuestionFrequentModel questionFrequent);
    Task<bool> DeleteQuestionFrequent(Guid id);
}
