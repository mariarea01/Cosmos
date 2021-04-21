using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmosWholesaleProject.Models
{
    public class ProductContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }
    }
}
