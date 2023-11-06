using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet
{
    public class Location
    {
        private int locationId;
        private string locationName;
        private int[,] locationMatrix;

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int LocationMatrix { get; set; }

        public Location()
        {
            locationId = 0;
            locationName = string.Empty;
            locationMatrix = new int[10, 10];
        }



    }
}
