using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onecore_API.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int CPY_ID { get; set; }

    }
}
