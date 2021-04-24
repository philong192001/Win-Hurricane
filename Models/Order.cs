using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechWiz.WinHurricane.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public int id_booking { get; set; }
        public string id_user { get; set; }
        public int sub_amount { get; set; }
    }
}
