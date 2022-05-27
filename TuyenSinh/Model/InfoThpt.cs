using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class InfoThpt
    {
        public int Id { get; set; }
        public int? Province10Id { get; set; }
        public int? Province11Id { get; set; }
        public int? Province12Id { get; set; }
        public int? School10Id { get; set; }
        public int? School11Id { get; set; }
        public int? School12Id { get; set; }
        public int? AbilityId { get; set; }
        public int? ConductId { get; set; }
        public double? Point { get; set; }
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
        public int? StudentId { get; set; }
        public int? Type { get; set; }
        public int? YearGraduation { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual Conduct Conduct { get; set; }
        public virtual Province Province10 { get; set; }
        public virtual School School10 { get; set; }
        public virtual Student Student { get; set; }
    }
}
