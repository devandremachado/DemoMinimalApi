namespace Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }
    }
}
