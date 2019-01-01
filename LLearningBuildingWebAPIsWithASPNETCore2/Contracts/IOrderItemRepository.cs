using LLearningBuildingWebAPIsWithASPNETCore2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LLearningBuildingWebAPIsWithASPNETCore2.Contracts
{
    public interface IOrderItemRepository
    {
        Task<OrderItem> Add(OrderItem item);

        IEnumerable<OrderItem> GetAll();

        Task<OrderItem> Find(int id);

        Task<OrderItem> Remove(int id);

        Task<OrderItem> Update(OrderItem item);

        Task<bool> Exists(int id);
    }
}
