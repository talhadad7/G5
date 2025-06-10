using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5
{
    public class EventTypeLookup
    {
        private string eventType;

        public EventTypeLookup(string eventType)
        {
            this.eventType = eventType;
        }

        public override string ToString()
        {
            return this.eventType;
        }

        public string GetEventType()
        {
            return this.eventType;
        }
    }
}
