namespace lab_13.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ñourses
    {
        [Key]
        public string NameCourse { get; set; }

        public string Lector { get; set; }

        public int CountHour { get; set; }

        public int StudNum { get; set; }

        public int MaxStudNum { get; set; }
    }
}
