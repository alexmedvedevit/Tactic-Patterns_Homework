using System.Collections.Generic;
using System.Linq;

namespace TacticPatterns
{
    public class CustomerRepository : IRepository<Customer>
    {
        public List<Customer> Customers;

        public CustomerRepository()
        {
            this.Customers = new List<Customer>();
        }


        public IEnumerable<Customer> GetAll()
        {
            return Customers;
        }

        public Customer GetById(int id)
        {
            return Customers.FirstOrDefault(elem => elem.Id == id);
        }

        public int Add(Customer elem)
        {
            Customers.Add(elem);
            return elem.Id;
        }

        public void Update(Customer elem)
        {
            foreach (var customer in Customers)
            {
                if (customer.Id == elem.Id)
                {
                    Customers[customer.Id] = elem;
                }
            }
        }

        public void Remove(int id)
        {
            foreach (var elem in Customers)
            {
                if (elem.Id == id)
                {
                    Customers.Remove(elem);
                    break;
                }
            }
        }
    }
}