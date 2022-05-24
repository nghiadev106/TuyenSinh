using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class Student
    {
        public Student()
        {
            ContactInfos = new HashSet<ContactInfo>();
            InfoThpts = new HashSet<InfoThpt>();
            Wishes = new HashSet<Wish>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? Dob { get; set; }
        public string Avatar { get; set; }
        public int? Gender { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public int? NationId { get; set; }
        public int? Cmnd { get; set; }
        public int? ProvinceId { get; set; }

        public virtual Nation Nation { get; set; }
        public virtual ICollection<ContactInfo> ContactInfos { get; set; }
        public virtual ICollection<InfoThpt> InfoThpts { get; set; }
        public virtual ICollection<Wish> Wishes { get; set; }
    }
}
