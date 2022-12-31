using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Interface.Repository.Users;

public interface IQuestionFrequentRepository
{
    Task<List<QuestionFrequentModel>> GetAllQuestionFrequent();
    Task<QuestionFrequentModel> GetQuestionFrequent(Guid id);
}
