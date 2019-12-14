using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDomLab4JakubKazimierski.Models
{
    class FBIcriminalsType
    {
        /// <summary>
        /// Creating columns in table FBIcriminalsType
        /// </summary>
        [Key]
        public int Id { get; set; }

        [DisplayName("Stopień Przestępcy")]
        public string Rank { get; set; }

        public virtual List<FBIcriminalsList> Criminals { get; set; }
    }
}
