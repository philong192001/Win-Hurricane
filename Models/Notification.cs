using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechWiz.WinHurricane.Models
{
    public class Notification
    {
        [Key]
        public int id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string id_user { get; set; }
    }
}
