using studioFlaviaBegosso.Infra.Data.Repositorys;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm
{
    public class QuestionFrequentRepository : BaseRepository<QuestionFrequentModel>, IQuestionFrequentRepository
    {
        public QuestionFrequentRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) {}

        public async Task<List<QuestionFrequentModel>> GetAllQuestionFrequent()
            => await SelectListAsync();

        public async Task<QuestionFrequentModel> GetQuestionFrequent(Guid id)
            => await SelectAsync(id);

        public async Task<bool> InsertQuestionFrequent(QuestionFrequentModel questionFrequent)
        {
            questionFrequent.DateCreation = DateTime.Now;
            questionFrequent.CreatedBy = "Flávia Alessandra Begosso";
            QuestionFrequentModel result = await InsertAsync(questionFrequent);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> UpdateQuestionFrequent(Guid id, QuestionFrequentModel questionFrequent)
        {
            questionFrequent.DateUpdate = DateTime.Now;
            questionFrequent.EditBy = "Flávia Alessandra Begosso";
            QuestionFrequentModel result = await UpdateAsync(id, questionFrequent);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> DeleteQuestionFrequent(Guid id)
        {
            bool result = await DeleteAsync(id);
            if (!result) return false;

            return true;
        }
    }
}
