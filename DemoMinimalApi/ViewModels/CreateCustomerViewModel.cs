using Domain.Entities;
using Flunt.Notifications;
using Flunt.Validations;

namespace DemoMinimalApi.ViewModels
{
    public class CreateCustomerViewModel : Notifiable<Notification>
    {
        public string? Name { get; set; }

        public Customer MapTo()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNullOrWhiteSpace(Name, nameof(Name)));

            return new Customer(Name);
        }
    }
}
