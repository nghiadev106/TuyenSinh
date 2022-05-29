using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class Wish
    {
        public int Id { get; set; }
        public int? Major1Id { get; set; }
        public int? Major2Id { get; set; }
        public int? Combination1Id { get; set; }
        public int? Combination2Id { get; set; }
        public string Point1 { get; set; }
        public string Point2 { get; set; }
        public int? StudentId { get; set; }

        public virtual Combination Combination1 { get; set; }
        public virtual Major Major1 { get; set; }
        public virtual Student Student { get; set; }
    }
}
