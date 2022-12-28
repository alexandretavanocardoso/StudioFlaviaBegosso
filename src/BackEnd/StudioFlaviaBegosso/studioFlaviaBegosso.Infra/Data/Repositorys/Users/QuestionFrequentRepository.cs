using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Users
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
