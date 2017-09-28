using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HybridIntegration.Models;

namespace HybridIntegration
{
    public class AppdbContext : DbContext
    {
        public AppdbContext()
            : base("name=DefaultConnection")
        {
        }
        public DbSet<Register> Registration { get; set; }
    }
}