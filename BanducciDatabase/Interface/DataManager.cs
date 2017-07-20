using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanducciModels;

namespace BanducciDatabase.Interface
{
    public class DataManager
    {
        private DataContext db = new DataContext();

        public void Create(Locations locations)
        {
            db.Locations.Add(locations);  
            db.SaveChanges();
        }

        
    }
}
