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
            db.Locations.Add(locations);  //todo BanducciDatabase.Locations: : EntityType 'Locations' has no key defined. Define the key for this EntityType.
                                          //todo Locations: EntityType: EntitySet 'Locations' is based on type 'Locations' that has no keys defined.
            db.SaveChanges();
        }

        
    }
}
