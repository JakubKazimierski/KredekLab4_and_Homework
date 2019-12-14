using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDomLab4JakubKazimierski.Models
{
    class FBIcriminalsList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Pole nazwisko jest wymagane")]
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        [DisplayName("Data Urodzin")]
        public DateTime Birthdate { get; set; }

        public int CriminalTypeId { get; set; }

        [ForeignKey("CriminalTypeId")]
        public virtual FBIcriminalsType FBIcriminalsType { get; set; }
    }
}
