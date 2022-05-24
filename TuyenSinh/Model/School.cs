using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class School
    {
        public School()
        {
            InfoThpts = new HashSet<InfoThpt>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProvinceId { get; set; }
        public int? Code { get; set; }

        public virtual ICollection<InfoThpt> InfoThpts { get; set; }
    }
}
