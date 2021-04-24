using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechWiz.WinHurricane.Models
{
    public class Booking
    {
        [Key]
        public int id { get; set; }
        public string id_user { get; set; }
        public int id_driver { get; set; }
        public string to { get; set; }
        public string from { get; set; }
        public string date { get; set; }
        public int distance { get; set; }
        public int amount { get; set; }
    }
}
