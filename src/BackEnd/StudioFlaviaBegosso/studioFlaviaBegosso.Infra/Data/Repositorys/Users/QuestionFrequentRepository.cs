using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Users
{
    public class QuestionFrequentRepository : BaseRepository<QuestionFrequentModel>, IQuestionFrequentRepository
    {
        public QuestionFrequentRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) { }

        public async Task<List<QuestionFrequentModel>> GetAllQuestionFrequent()
            => await SelectListAsync();

        public async Task<QuestionFrequentModel> GetQuestionFrequent(Guid id)
            => await SelectAsync(id);
    }
}
