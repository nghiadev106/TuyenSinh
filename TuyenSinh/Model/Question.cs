﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public bool? IsNew { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }
        public int? Status { get; set; }
    }
}
