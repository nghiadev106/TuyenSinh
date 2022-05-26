using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuyenSinh.Areas.Admin.Models.Major
{
    public class MajorRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public string Code { get; set; }
        public double? Combination1 { get; set; }
        public double? Combination2 { get; set; }
        public double? Combination3 { get; set; }
        public double? Combination4 { get; set; }
    }
}
