using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys
{
    public class QuestionFrequentRepository : IQuestionFrequentRepository
    {
        private StudioFlaviaBegossoContext _studioFlaviaBegossoContext;

        public QuestionFrequentRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext)
        {
            _studioFlaviaBegossoContext = studioFlaviaBegossoContext;
        }
    }
}
