using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDomLab4JakubKazimierski.Models
{
    class FBIagentsType
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Stopień Agenta")]
        public string Rank { get; set; }

        public virtual List<FBIagentsList> Agents { get; set; }
    }
}
