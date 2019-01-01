using LLearningBuildingWebAPIsWithASPNETCore2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LLearningBuildingWebAPIsWithASPNETCore2.Contracts
{
    public interface IProductRepository
    {
        Task<Product> Add(Product item);

        IEnumerable<Product> GetAll();

        Task<Product> Find(string id);

        Task<Product> Remove(string id);

        Task<Product> Update(Product item);

        Task<bool> Exists(string id);
    }
}
