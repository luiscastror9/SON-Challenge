using System;
using System.Data.Entity;
using System.Linq;

namespace BusinessLayer
{
    public class Model : DbContext
    {
        // Your context has been configured to use a 'Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BusinessLayer.Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model' 
        // connection string in the application configuration file.
        public Model()
            : base("name=DefaultConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public  DbSet<Customer> Customer { get; set; }
        public  DbSet<Order> Order { get; set; }
        public  DbSet<Order.OrderDetail> OrderDetails { get; set; }
        public  DbSet<Order.Mixing> Mixing { get; set; }
         public  DbSet<Order.Status> Status { get; set; }

    }

  
}