using LLearningBuildingWebAPIsWithASPNETCore2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LLearningBuildingWebAPIsWithASPNETCore2.Contracts
{
    public interface IOrderRepository
    {
        Task<Order> Add(Order item);

        IEnumerable<Order> GetAll();

        Task<Order> Find(int id);

        Task<Order> Remove(int id);

        Task<Order> Update(Order item);

        Task<bool> Exists(int id);
    }
}
