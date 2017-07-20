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
            _data = new LocationsDBManager();
        }

        private LocationsDBManager _data;

        public void Create(BanducciModels.Locations model)
        {
            _data.Create(model);
        }
    }
}
