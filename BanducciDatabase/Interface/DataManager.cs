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
        public Locations List()  //todo  fix issue
        {
            var DbList = db.Locations.ToList();
            //return DbList;
            return null;
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
        public Locations FindId(int? id)
        {
            var dbitem = db.Locations.Find(id);
            return dbitem;

        }

        //delete location from database
        public void DeleteStore(Locations locations)
        {
            db.Locations.Remove(locations);
            db.SaveChanges();
        }


        
    }
}
