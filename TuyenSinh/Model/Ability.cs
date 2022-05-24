using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class Ability
    {
        public Ability()
        {
            InfoThpts = new HashSet<InfoThpt>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InfoThpt> InfoThpts { get; set; }
    }
}
