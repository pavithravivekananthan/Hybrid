using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using HybridIntegration.Models;

namespace HybridIntegration
{
    public class AppdbContext1 : DbContext
    {
   
        public AppdbContext1()
            : base("name=MS_TableConnectionString")
        {
        }
        public DbSet<Register> Registration { get; set; }
    }
}