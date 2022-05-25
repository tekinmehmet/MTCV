using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTCV.Models.ENTITY
{
    public class Skill
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string SKILL { get; set; }
       
        public byte Oran { get; set; }

    }
}