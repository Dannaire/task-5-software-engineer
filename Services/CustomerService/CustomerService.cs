using Customer_Api.Models;

namespace Customer_Api.Services.CustomerService
{
    public class CustomerService
    {
        private static List<Customer> listCustomer = new List<Customer>
        {
            

        };

        public async Task<List<Customer>> getAllCustomer()
        {
            return listCustomer;
        }
        public async Task<Customer> getCustomerById(int Id)
        {
            var customer = listCustomer.Find(x => x.Id == Id);
            if (customer is null)
            {
                return null;
            }
            return customer;
        }


        public async Task<List<Customer>> addCustomer(Customer addCustomer)
        {
            listCustomer.Add(addCustomer);
            return listCustomer;
        }


        public async Task<List<Customer>> updateCustomerById(int Id, Customer requestUpdate)
        {
            var customer = listCustomer.Find(x => x.Id == Id);
            if (customer is null) { return null; }
            customer.FirstName = requestUpdate.FirstName;
            customer.LastName = requestUpdate.LastName;
            customer.Email = requestUpdate.Email;
            customer.HomeAddress = requestUpdate.HomeAddress;

            return listCustomer;
        }


        public async Task<List<Customer>> deleteCustomerById(int Id)
        {
            var customer = listCustomer.Find(x => x.Id == Id);
            if (customer is null) { 
                return null; 
            }


            listCustomer.Remove(customer);
            return listCustomer;
        }
    }
}
