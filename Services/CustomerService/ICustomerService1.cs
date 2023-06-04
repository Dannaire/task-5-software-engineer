using Customer_Api.Models;

namespace Customer_Api.Services.CustomerService
{
    public interface ICustomerService1
    {
        Task<List<Customer>> addCustomer(Customer addCustomer);
        Task<List<Customer>> deleteCustomerById(int customerId);
        Task<List<Customer>> getAllCustomer();
        Task<Customer> getCustomerById(int Id);
        Task<List<Customer>> updateCustomerById(int Id, Customer requestUpdate);
    }
}