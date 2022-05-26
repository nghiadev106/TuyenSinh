using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuyenSinh.Models
{
    public class MajorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public string Code { get; set; }
        public double? Combination1Id { get; set; }
        public double? Combination2Id { get; set; }
        public double? Combination3Id { get; set; }
        public double? Combination4Id { get; set; }
        public string Combination1Name { get; set; }
        public string Combination2Name { get; set; }
        public string Combination3Name { get; set; }
        public string Combination4Name { get; set; }
    }
}
