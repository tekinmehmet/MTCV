using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTCV.Models.ENTITY
{
    public class AboutMe
    {
        [Key]
        public int ID { get; set; }
        [StringLength(30)]
        public string NAME { get; set; }
        [StringLength(30)]
        public string SURNAME { get; set; }
        [StringLength(100)]
        public string ADRESS { get; set; }
        [StringLength(20)]
        public string PHONENUMBER { get; set; }
        [StringLength(50)]
        public string EMAIL { get; set; }
        [StringLength(1000)]
        public string DESCRIPTION { get; set; }
    }
}