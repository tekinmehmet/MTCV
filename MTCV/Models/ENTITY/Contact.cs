using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTCV.Models.ENTITY
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string NAMESURNAME { get; set; }
        [StringLength(100)]
        public string EMAIL { get; set; }
        [StringLength(100)]
        public string SUBJECT { get; set; }
        [StringLength(1000)]
        public string DATE { get; set; }
       
       
    }
}