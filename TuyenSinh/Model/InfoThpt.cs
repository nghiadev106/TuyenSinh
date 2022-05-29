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
        public string Point { get; set; }
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
