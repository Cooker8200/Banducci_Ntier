using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanducciModels;
using System.Data.Entity;

namespace BanducciDatabase.Interface
{
    public class DataManager
    {
        private DataContext db = new DataContext();

        //return list of stores
        public void List()  //todo  fix issue
        {
            db.Locations.ToList();
        }

        //add location to database
        public void Create(Locations locations)
        {
            db.Locations.Add(locations);  
            db.SaveChanges();
        }

        //edit location
        public void Edit(Locations locations)
        {
            db.Entry(locations).State = EntityState.Modified;
            db.SaveChanges();
        }

        //find location id to return viewmodel
        public void FindId(int? id)
        {
            db.Locations.Find(id);

        }

        //delete location from database
        public void DeleteStore(Locations locations)
        {
            db.Locations.Remove(locations);
            db.SaveChanges();
        }


        
    }
}
