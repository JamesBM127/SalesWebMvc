using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcDbContext : DbContext
    {
        public SalesWebMvcDbContext(DbContextOptions<SalesWebMvcDbContext> options) : base(options)
        {

        }
    }
}
