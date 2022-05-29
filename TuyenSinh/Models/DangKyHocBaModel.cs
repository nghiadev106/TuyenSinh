using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuyenSinh.Models
{
    public class DangKyHocBaModel
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public DateTime? Dob { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? Gender { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? NationId { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? Cmnd { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? ProvinceId { get; set; }


        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? Province10Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? Province11Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? Province12Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? School10Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? School11Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? School12Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? AbilityId { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? ConductId { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Point { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? YearGraduation { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Sbd { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Math { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Literature { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string English { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Physics { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Chemistry { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Biology { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string History { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Geography { get; set; }


        public string Graduation { get; set; }

        public string ScoreCard { get; set; }
        public int? Type { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string ContactName { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? ContactPhone { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string ContactAddress { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? ContactSubjectTo { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? ContactBhyt { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? Major1Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? Major2Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? Combination1Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public int? Combination2Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Point1 { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Point2 { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập")]
        public IFormFile GraduationFile { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập")]
        public IFormFile ScoreCardFile { get; set; }

    }
}
