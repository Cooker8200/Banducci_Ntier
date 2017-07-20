namespace BanducciDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Location
    {
        public int id { get; set; }

        public int? storeid { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public int? zipcode { get; set; }

        public string phone { get; set; }
    }
}
