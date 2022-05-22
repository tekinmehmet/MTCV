using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTCV.Models.ENTITY
{
    public class Interest
    {
        [Key]
        public int ID { get; set; }
        [StringLength(1000)]
        public string DESC1 { get; set; }
        [StringLength(500)]
        public string DESC2 { get; set; }

    }
}