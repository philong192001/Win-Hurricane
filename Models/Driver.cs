using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechWiz.WinHurricane.Models
{
    public class Driver
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string phone { get; set; }
        public string id_proof { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public string id_car { get; set; }
    }
}
