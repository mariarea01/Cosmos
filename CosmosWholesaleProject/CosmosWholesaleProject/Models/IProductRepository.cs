using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmosWholesaleProject.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
