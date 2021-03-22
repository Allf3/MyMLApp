using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccesLayer.Entity
{
    public class Comment
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime PostedDate { get; set; }

        public bool Toxic { get; set; }
    }
}
