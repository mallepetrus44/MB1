using ModellenBureau.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.API.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MBDbContext _mBDbContext;

        public CustomerRepository(MBDbContext mBDbContext)
        {
            _mBDbContext = mBDbContext;
        }


        public Customer AddCustomer(Customer customer)
        {
            var addCustomer = _mBDbContext.Customers.Add(customer);
            _mBDbContext.SaveChanges();
            return addCustomer.Entity;
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = _mBDbContext.Customers.FirstOrDefault(e => e.CustomerID == customerId);
            if (customer == null) return;

            _mBDbContext.Customers.Remove(customer);
            _mBDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _mBDbContext.Customers;
        }

        public Customer GetCustomerById(int customerId)
        {
            return _mBDbContext.Customers.FirstOrDefault(c => c.CustomerID == customerId);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var updateCustomer = _mBDbContext.Customers.FirstOrDefault(e => e.CustomerID == customer.CustomerID);

            if (updateCustomer != null)
            {
                updateCustomer.Voornaam = customer.Voornaam;
                updateCustomer.Achternaam = customer.Achternaam;
                updateCustomer.Adres = customer.Adres;
                updateCustomer.Postcode = customer.Postcode;
                updateCustomer.Logo = customer.Logo;
                updateCustomer.KvkNummer = customer.KvkNummer;
                updateCustomer.BtwNummer = customer.BtwNummer;
                updateCustomer.Stad = customer.Stad;
                updateCustomer.Verified = false;

                _mBDbContext.SaveChanges();

                return updateCustomer;
            }

            return null;
        }
    }
}
