using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class Combination
    {
        public Combination()
        {
            Wishes = new HashSet<Wish>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Wish> Wishes { get; set; }
    }
}
