using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class ContactInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Phone { get; set; }
        public string Address { get; set; }
        public int? SubjectToId { get; set; }
        public int? Bhyt { get; set; }
        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual SubjectTo SubjectTo { get; set; }
    }
}
