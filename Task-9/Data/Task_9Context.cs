using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task_9.Data
{
    public class Task_9Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Task_9Context() : base("name=Task_9Context")
        {
        }

        public System.Data.Entity.DbSet<Task_9.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<Task_9.Models.Course> Courses { get; set; }
    }
}
