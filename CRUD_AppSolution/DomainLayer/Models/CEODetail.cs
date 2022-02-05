using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer.Models
{
    public class CEODetail
    {
        [Key]
        public int CEOID { get; set; }
        public string  CEO_Name { get; set; }
        public DateTime StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
