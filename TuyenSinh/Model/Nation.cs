using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class Nation
    {
        public Nation()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
