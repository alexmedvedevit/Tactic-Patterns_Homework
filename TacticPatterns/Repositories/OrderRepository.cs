using System.Collections.Generic;
using System.Linq;

namespace TacticPatterns
{
    public class OrderRepository : IRepository<Order>
    {
        public List<Order> Orders;

        public OrderRepository()
        {
            this.Orders = new List<Order>();
        }


        public IEnumerable<Order> GetAll()
        {
            return Orders;
        }

        public Order GetById(int id)
        {
            return Orders.FirstOrDefault(elem => elem.Id == id);
        }

        public int Add(Order elem)
        {
            Orders.Add(elem);
            return elem.Id;
        }

        public void Update(Order elem)
        {
            foreach (var order in Orders)
            {
                if (order.Id == elem.Id)
                {
                    Orders[order.Id] = elem;
                }
            }
        }

        public void Remove(int id)
        {
            foreach (var elem in Orders)
            {
                if (elem.Id == id)
                {
                    Orders.Remove(elem);
                    break;
                }
            }
        }
    }
}