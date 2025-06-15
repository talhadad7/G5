using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Group
{
    public string groupName { get; set; }
    public int groupYear { get; set; }

    public Group(string groupName, int groupYear)
    {
        this.groupName = groupName;
        this.groupYear = groupYear;
    }

    public override string ToString()
    {
        return $"{groupName} ({groupYear})";
    }
}
