using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Onecore_API.Models
{
    public class Emissores
    {
        [Key]
        public int EM_ID { get; set; }

        public string Desc_Emissor { get; set; }
    }
}
