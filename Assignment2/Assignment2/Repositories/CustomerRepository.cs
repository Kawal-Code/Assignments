using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2.MyEntities;
namespace Assignment2.Repositories
{
    public class CustomerRepository
    {
        public CustomerContext db = new CustomerContext();
        public List<Customer> GetCustomers()
        {
            return db.Customers.ToList(); 
        }
        public Customer GetCustomerById(string Cid)
        {
            return db.Customers.Find(Cid); 
        }
        public void Add(Customer c)
        {
            db.Customers.Add(c); 
            db.SaveChanges();
        }
        public void Delete(Customer c)
        {
            db.Customers.Remove(c); 
            db.SaveChanges();
        }
        public void Update(Customer c)
        {
            db.Customers.Update(c); 
            db.SaveChanges();
        }
    
}
}
