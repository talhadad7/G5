using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5
{
    public class Tag
    {
        // Property
        public string tagType { get; set; }

        // Constructor
        public Tag(string tagType1)
        {
            this.tagType = tagType1;
        }

        // Optional: override ToString for debugging / display
        public override string ToString()
        {
            return $"Tag: {tagType}";
        }
    }
}

