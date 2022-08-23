using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BLL
{
    public class CustomerBLL
    {
        private Model _model { get; set; }

        public List<Customer> GetAllCustomer(string email)
        {
            return _model.Customer.ToList();
        }
        public Customer GetCustomerbyEmail(string email)
        {
            return _model.Customer.Where(x=>x.Email==email).FirstOrDefault();
        }

        public Customer AddCustomer(string name, string address, string email)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentNullException("address");

            }
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("email");
            }
            Customer customer = new Customer
            {
                Name = name,
                Address = address,
                Email = email
            };
            return _model.Customer.Add(customer);

        }

        public Customer UpdateCustomer(string name, string address, string email)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentNullException("address");

            }
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("email");
            }

            Customer customer = _model.Customer.Where(x=>x.Email==email).FirstOrDefault();
            if (customer == null)
                throw new ArgumentNullException();

            customer.Name = name;
            customer.Address = address;
            customer.Email = email;
            _model.Entry(customer).State = EntityState.Modified;
            _model.SaveChanges();
            return customer;

        }
        public bool DeleteCustomer(string email)
        {
            Customer customer = _model.Customer.Where(x => x.Email == email).FirstOrDefault();
            if (customer == null)
                throw new ArgumentNullException();
            _model.Entry(customer).State = EntityState.Deleted;
            _model.SaveChanges();
            return true;
        }
    }
}
