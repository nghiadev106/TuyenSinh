using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class Province
    {
        public Province()
        {
            Districts = new HashSet<District>();
            InfoThpts = new HashSet<InfoThpt>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<InfoThpt> InfoThpts { get; set; }
    }
}
