using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommonModule.Services
{
    public class DataBaseService
    {
        private static DataBaseService _instance;
        public DataBaseService()
        {
            DataBaseContext = new DataBaseContext();
        }
        private DataBaseContext DataBaseContext;

        public static DataBaseService GetInstance()
        {
            return _instance ?? (_instance = new DataBaseService());
        }

        public void AddOrder(Order order)
        {
            using (var context = new DataBaseService().DataBaseContext)
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void RemoveOrder(Order checkedOrder)
        {
            using (var context = new DataBaseService().DataBaseContext)
            {
                context.Orders.Attach(checkedOrder);
                context.Orders.Remove(checkedOrder);
                context.SaveChanges();
            }
        }
        public Order[] GetAllOrders()
        {
            using (var context = new DataBaseService().DataBaseContext)
            {
                return context.Orders.ToArray();
            }
        }

        public void SaveOrder(Order savedOrder)
        {
            using (var context = new DataBaseService().DataBaseContext)
            {
                
                context.Entry(savedOrder).State = System.Data.Entity.EntityState.Modified;
                
                context.SaveChanges();
            }
        }
        
    }
}
