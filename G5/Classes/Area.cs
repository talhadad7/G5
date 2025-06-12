using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5
{
    public class Area
    {
        // Properties
        public string AreaID { get; set; }
        public string AreaName { get; set; }
        public double Size { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor
        public Area(string areaID, string areaName, double size, bool isAvailable)
        {
            AreaID = areaID;
            AreaName = areaName;
            Size = size;
            IsAvailable = isAvailable;
        }

        // Optional: override ToString for easy display
        public override string ToString()
        {
            return $"Area ID: {AreaID}, Name: {AreaName}, Size: {Size} sqm, Available: {IsAvailable}";
        }
    }
}
