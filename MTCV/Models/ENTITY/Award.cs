using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTCV.Models.ENTITY
{
    public class Award
    {
        [Key]
        public int ID { get; set; }
        [StringLength(1000)]
        public string DESCRIPTION { get; set; }
       
    }
}