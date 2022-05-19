using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTCV.Models.ENTITY
{
    public class Experience
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string HEAD { get; set; }
        [StringLength(100)]
        public string SUBHEAD { get; set; }
        [StringLength(1000)]

        public string DESCRIPTION { get; set; }
        [StringLength(40)]
        public string DATE { get; set; }
    }
}