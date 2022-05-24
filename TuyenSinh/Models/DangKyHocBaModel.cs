using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuyenSinh.Models
{
    public class DangKyHocBaModel
    {
        public int? StudentId { get; set; }
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

        public int? Province10Id { get; set; }
        public int? Province11Id { get; set; }
        public int? Province12Id { get; set; }
        public int? School10Id { get; set; }
        public int? School11Id { get; set; }
        public int? School12Id { get; set; }
        public int? AbilityId { get; set; }
        public int? ConductId { get; set; }
        public double? Point { get; set; }
        public int? YearGraduation { get; set; }
        public string Sbd { get; set; }
        public string Hsddkxt { get; set; }
        public double? Math { get; set; }
        public double? Literature { get; set; }
        public double? English { get; set; }
        public double? Physics { get; set; }
        public double? Chemistry { get; set; }
        public double? Biology { get; set; }
        public double? History { get; set; }
        public double? Geography { get; set; }
        public string Graduation { get; set; }
        public string ScoreCard { get; set; }

        public string ContactName { get; set; }
        public int? ContactPhone { get; set; }
        public string ContactAddress { get; set; }
        public int? ContactSubjectTo { get; set; }
        public int? ContactBhyt { get; set; }

        public int? Major1Id { get; set; }
        public int? Major2Id { get; set; }
        public int? Combination1Id { get; set; }
        public int? Combination2Id { get; set; }
        public double? Point1 { get; set; }
        public double? Point2 { get; set; }

        public IFormFile GraduationFile { get; set; }
        public IFormFile ScoreCardFile { get; set; }

    }
}
