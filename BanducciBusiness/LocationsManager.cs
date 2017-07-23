using BanducciModels;
using BanducciDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BanducciBusiness
{
    public class LocationsManager
    {
        public LocationsManager()
        {
            _data = new BanducciDatabase.Interface.DataManager();
        }

        private BanducciDatabase.Interface.DataManager _data;

        public void List()
        {
            _data.List();
        }

        public void Create(Locations model)
        {
            _data.Create(model);
        }

        public void EditStore(Locations model)
        {
            _data.Edit(model);

        }

        public void GetId(int? id)
        {
            _data.FindId(id);

        }

        public void Delete(Locations locations)
        {
            _data.DeleteStore(locations);
        }

        
    }
}
