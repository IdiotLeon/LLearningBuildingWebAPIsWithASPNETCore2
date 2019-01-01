using LLearningBuildingWebAPIsWithASPNETCore2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LLearningBuildingWebAPIsWithASPNETCore2.Contracts
{
    public interface ISalespersonRepository
    {
        Task<Salesperson> Add(Salesperson person);

        IEnumerable<Salesperson> GetAll();

        Task<Salesperson> Find(int id);

        Task<Salesperson> Remove(int id);

        Task<Salesperson> Update(Salesperson person);

        Task<bool> Exists(int id);
    }
}
