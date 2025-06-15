using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5
{
    public class ActivityDay
    {
        // שמות משתנים בדיוק כמו ב-SQL
        public DateTime activityDate { get; set; }
        public int? totalDayAttendance { get; set; }
        public string summary { get; set; }

        public ActivityDay(DateTime activityDate, int? totalDayAttendance = null, string summary = null)
        {
            if (totalDayAttendance < 0)
                throw new ArgumentException("totalDayAttendance must be non-negative.");

            this.activityDate = activityDate;
            this.totalDayAttendance = totalDayAttendance;
            this.summary = summary;
        }

        public ActivityDay() { }

        public override string ToString()
        {
            return $"Date: {activityDate:yyyy-MM-dd}, Attendance: {totalDayAttendance ?? 0}, Summary: {summary}";
        }
    }
}
