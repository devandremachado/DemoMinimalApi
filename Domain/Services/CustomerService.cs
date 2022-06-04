using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer? GetById(Guid id)
        {
            return _customerRepository.GetById(id);
        }

        public bool Remove(Guid id)
        {
            return _customerRepository.Remove(id);
        }
    }
}
