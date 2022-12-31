using studioFlaviaBegosso.Domain.Dto;

namespace studioFlaviaBegosso.Domain.Interface.Service.Users;

public interface IQuestionFrequentService {
    Task<List<QuestionFrequentDto>> GetAllQuestionFrequentAsync();
    Task<QuestionFrequentDto> GetQuestionFrequentAsync(Guid id);
}
