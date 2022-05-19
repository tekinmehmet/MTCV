using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTCV.Models.ENTITY
{
    public class Login
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string USERNAME { get; set; }
        [StringLength(20)]
        public string PASSWORD { get; set; }

    }
}