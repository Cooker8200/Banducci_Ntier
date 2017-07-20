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

        public void Create(Locations model)
        {
            _data.Create(model);
        }
    }
}
