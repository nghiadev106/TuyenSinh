using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuyenSinh.Areas.Admin.Models.Student
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }


        public string Name { get; set; }


        public string Phone { get; set; }


        public string Email { get; set; }


        public string Address { get; set; }


        public DateTime? Dob { get; set; }


        public int? Gender { get; set; }

        public int? Status { get; set; }

        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }


        public int? NationId { get; set; }


        public int? Cmnd { get; set; }


        public int? ProvinceId { get; set; }



        public int? Province10Id { get; set; }


        public int? Province11Id { get; set; }


        public int? Province12Id { get; set; }


        public int? School10Id { get; set; }


        public int? School11Id { get; set; }


        public int? School12Id { get; set; }


        public int? AbilityId { get; set; }


        public int? ConductId { get; set; }


        public string Point { get; set; }


        public int? YearGraduation { get; set; }


        public string Sbd { get; set; }


        public string Hsddkxt { get; set; }


        public string Math { get; set; }


        public string Literature { get; set; }


        public string English { get; set; }


        public string Physics { get; set; }


        public string Chemistry { get; set; }


        public string Biology { get; set; }


        public string History { get; set; }


        public string Geography { get; set; }

        public string Graduation { get; set; }

        public string ScoreCard { get; set; }
        public int? Type { get; set; }


        public string ContactName { get; set; }


        public int? ContactPhone { get; set; }


        public string ContactAddress { get; set; }


        public int? ContactSubjectTo { get; set; }


        public int? ContactBhyt { get; set; }


        public int? Major1Id { get; set; }


        public int? Major2Id { get; set; }


        public int? Combination1Id { get; set; }


        public int? Combination2Id { get; set; }


        public string Point1 { get; set; }


        public string Point2 { get; set; }
    }
}
