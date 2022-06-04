using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers;

        public CustomerRepository()
        {
            _customers = new List<Customer>();
            InitiateDb();
        }

        private void InitiateDb()
        {
            _customers.Add(new Customer("Andre"));
            _customers.Add(new Customer("Felipe"));
            _customers.Add(new Customer("Lucas"));
            _customers.Add(new Customer("Isaac"));
        }

        public bool Add(Customer customer)
        {
            _customers.Add(customer);
            return true;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customers ?? new List<Customer>();
        }

        public Customer? GetById(Guid id)
        {
            return _customers.FirstOrDefault(x => x.Id == id);
        }

        public bool Remove(Guid id)
        {
            var customer = _customers.FirstOrDefault(x => x.Id == id);

            if (customer is null)
                return false;

            _customers.Remove(customer);
            return true;
        }
    }
}
