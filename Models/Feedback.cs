using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechWiz.WinHurricane.Models
{
    public class Feedback
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string user_id { get; set; }
        public string description { get; set; }
    }
}
