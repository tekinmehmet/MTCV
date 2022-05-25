using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTCV.Models.ENTITY
{
    public class Education
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]/*[Required(ErrorMessage ="Bu alanı boş geçemezsiniz.")]*/
        public string HEAD { get; set; }
        [StringLength(100)]
        public string SUBHEAD { get; set; }
        [StringLength(100)]
        public string SUBHEAD2 { get; set; }
        [StringLength(10)]
        public string GNO { get; set; }
        [StringLength(40)]
        public string DATE { get; set; }
        [StringLength(100)]
        public string PHOTOURL { get; set; }


    }
}