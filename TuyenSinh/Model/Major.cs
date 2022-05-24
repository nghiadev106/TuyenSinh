using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class Major
    {
        public Major()
        {
            Wishes = new HashSet<Wish>();
        }

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

        public virtual ICollection<Wish> Wishes { get; set; }
    }
}
