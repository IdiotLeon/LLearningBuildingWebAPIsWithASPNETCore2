using LLearningBuildingWebAPIsWithASPNETCore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLearningBuildingWebAPIsWithASPNETCore2.Contracts
{
    public interface ICustomerRepository
    {
        Task<Customer> Add(Customer customer);

        IEnumerable<Customer> GetAll();

        Task<Customer> Find(int id);

        Task<Customer> Update(Customer customer);

        Task<Customer> Remove(int id);

        Task<bool> Exist(int id);
    }
}
