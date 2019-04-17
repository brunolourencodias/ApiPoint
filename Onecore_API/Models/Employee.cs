using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onecore_API.Models
{
    
    public class Employee
    {
        [Key]
        public int EMP_ID { get; set; }
        public int EMP_REGISTER { get; set; }       
        public string EMP_FULLNAME { get; set; }
        public DateTime EMP_DATEBORN { get; set; }
        public string EMP_GENRE { get; set; }
        public string EMP_CPF { get; set; }
        public DateTime EMP_DATEADMISSION { get; set; }
        public string EMP_RG { get; set; }
        public string EMP_SCHOOLING { get; set; }
        public string EMP_TELEPHONE { get; set; }
        public string EMP_PHONE { get; set; }
        public string EMP_EMAIL { get; set; }
        public Byte? EMP_PICTURE { get; set; }
        public string EMP_ROLE { get; set; }

        [ForeignKey("EM_ID")]
        public int EM_ID { get; set; }

        [ForeignKey("CPY_ID")]
        public int CPY_ID { get; set; }
    }
}
