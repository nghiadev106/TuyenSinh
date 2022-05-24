using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class SubjectTo
    {
        public SubjectTo()
        {
            ContactInfos = new HashSet<ContactInfo>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ContactInfo> ContactInfos { get; set; }
    }
}
