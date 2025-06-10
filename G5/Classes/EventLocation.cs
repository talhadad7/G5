using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5
{

    public class EventLocationLookup
    {
        private string locationName;

        public EventLocationLookup(string locationName)
        {
            this.locationName = locationName;
        }

        public override string ToString()
        {
            return this.locationName;
        }

        public string GetLocationName()
        {
            return this.locationName;
        }
    }
}
