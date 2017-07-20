using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanducciModels;

namespace BanducciDatabase
{

    public class LocationsDBManager
    {
        private Data.BanducciDataEntities db = new Data.BanducciDataEntities();

        //private DataContext db = new DataContext();  
        //public List<Data.Location> List()
        //{
        //    locationData.Locations.ToList();

        //}
        
        public void Create(BanducciModels.Locations locations)
        {
            db.Locations.Add(locations);
            db.SaveChanges();
        }

        public void Delete()
        {
            //todo
        }

        public void Modify()
        {
            //todo
        }

    }
}
