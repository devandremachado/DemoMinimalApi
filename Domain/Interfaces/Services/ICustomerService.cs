using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer? GetById(Guid id);

        bool Add(Customer customer);
        bool Remove(Guid id);
    }
}
