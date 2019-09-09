using miningstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.ViewModels
{
    public class HomeViewModels
    {
        public IEnumerable<Product> favProducts { get; set; }
    }
}
