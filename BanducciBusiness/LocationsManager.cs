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

        public Locations List()
        {
            var LocManagerDbList = _data.List();
            return LocManagerDbList;
        }

        public void Create(Locations model)
        {
            _data.Create(model);
        }

        public void EditStore(Locations model)
        {
            _data.Edit(model);

        }

        public Locations GetId(int? id)
        {
            var LocManagerDbId = _data.FindId(id);
            return LocManagerDbId;

        }

        public void Delete(Locations locations)
        {
            _data.DeleteStore(locations);
        }

        
    }
}
