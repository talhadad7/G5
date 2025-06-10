using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5
{

    public class AgeGroupLookup
    {
        private string ageGroup;

        public AgeGroupLookup(string ageGroup)
        {
            this.ageGroup = ageGroup;
        }

        public override string ToString()
        {
            return this.ageGroup;
        }

        public string GetAgeGroup()
        {
            return this.ageGroup;
        }
    }
}

