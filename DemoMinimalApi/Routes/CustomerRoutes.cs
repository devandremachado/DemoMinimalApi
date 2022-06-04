using DemoMinimalApi.ViewModels;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace DemoMinimalApi.Routes
{
    public static class CustomerRoutes
    {
        public static void ConfigureCustomerRoutes(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapGet("/customers/{id}", GetCustomerById);
            app.MapPost("/customers", AddCustomer);
            app.MapDelete("/customers/{id}", RemoveCustomer);
        }

        private static IResult GetCustomers(ICustomerService customerService)
        {
            return Results.Ok(customerService.GetAll());
        }

        private static IResult GetCustomerById(Guid id, ICustomerService customerService)
        {
            var customer = customerService.GetById(id);

            return customer is null ? Results.NotFound() : Results.Ok(customer);
        }

        private static IResult AddCustomer(CreateCustomerViewModel model, ICustomerService customerService)
        {
            var customer = model.MapTo();
            if (model.IsValid == false)
                return Results.BadRequest(model.Notifications);

            var success = customerService.Add(customer);
            if (success)
                return Results.Created($"/customers/{customer.Id}", customer);

            return Results.Problem("Unable to create customer");
        }

        private static IResult RemoveCustomer(Guid id, ICustomerService customerService)
        {
            var success = customerService.Remove(id);

            if (success)
                return Results.Ok($"Customer - {id}, Created");

            return Results.Problem("Unable to create customer");

        }
    }
}
