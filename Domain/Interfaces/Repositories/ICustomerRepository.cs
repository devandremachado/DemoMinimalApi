using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer? GetById(Guid id);

        bool Add(Customer customer);
        bool Remove(Guid id);
    }
}
