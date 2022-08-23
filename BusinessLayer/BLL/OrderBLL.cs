using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BusinessLayer.BLL
{
    public class OrderBLL
    {
        private Model _model { get; set; }
        public OrderBLL()
        {
            _model = new Model();
        }
        public List<Order> GetAllOrder()
        {
            return _model.Order.Include(c => c.OrderDetails).ToList();
        }

        public List<Order> GetAllOrder(DateTime startDate,DateTime endDate)
        {
            return _model.Order.Where(x=>x.OrderDate>=startDate && x.OrderDate<=endDate).ToList();
        }

        public Order GetOrderbyId(int id)
        {
            return _model.Order.Include(c => c.OrderDetails).Where(x=>x.Id==id).FirstOrDefault();
        }

        public List<Dictionary<string, string>> RankMixing()
        {
            List<Dictionary<string, string>> keyValuePairs = new List<Dictionary<string, string>>();
            var query = (from t in _model.OrderDetails
                         group t by new { t.Mixing.Name }
                         into grp
                         select new
                         {
                             grp.Key.Name,
                             Qty = grp.Sum(t => t.Qty)
                         }
                         ).ToList();
            query.ForEach(x =>
            {
                Dictionary<string, string> valuePairs = new Dictionary<string, string>();
                valuePairs.Add("Mixing", x.Name);
                keyValuePairs.Add(valuePairs);
            });
            return keyValuePairs;
        }

        public List<int> PopularHours(DateTime startDate, DateTime endDate)
        {
           
            List<int> keyValuePairs = new List<int>();
            var query = (from t in _model.Order
                         where t.OrderDate >= startDate && t.OrderDate <= endDate
                         group t by new { t.OrderDate }
                         into grp                         
                         select new
                         {
                             grp.Key.OrderDate.Hour,
                             Qty = grp.Sum(t => t.Id)
                         }
                         ).OrderByDescending(c=>c.Hour).ToList();
            query.ForEach(x =>
            {
                keyValuePairs.Add(x.Hour);
            });
            return keyValuePairs.Take(3).ToList();
        }

        public Order AddOrder()
        {
          
            Order Order = new Order
            {
              
            };
            return _model.Order.Add(Order);

        }

    }
}
