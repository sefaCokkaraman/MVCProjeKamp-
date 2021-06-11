using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concerete
{
    public class About
    {
     
        [Key]
        public int AboutID { get; set; }
        [StringLength(1000)]
        public string AboutDetail1 { get; set; }
        [StringLength(1000)]
        public string AboutDetail2 { get; set; }
        [StringLength(100)]
        public string AboutImage1 { get; set; }
        [StringLength(100)]
        public string AboutImage2 { get; set; }



    }
}
