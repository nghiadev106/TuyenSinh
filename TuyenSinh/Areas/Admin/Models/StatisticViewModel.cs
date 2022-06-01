using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuyenSinh.Areas.Admin.Models
{
    public class StatisticViewModel
    {
        public int Student { get; set; }
        public int StudentPass { get; set; }
        public int StudentFail { get; set; }
        public int StudentWait { get; set; }
    }
}
