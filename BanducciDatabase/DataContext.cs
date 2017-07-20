using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BanducciDatabase
{
    public class DataContext : DbContext
    {
        public  DataContext() : base("name=BanducciContext")
        {

        }

        public DbSet<Locations> Locations { get; set; }
    }
}
