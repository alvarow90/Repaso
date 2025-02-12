using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoAlvaro.Shared.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name="Ciudad")]
        [MaxLength(70,ErrorMessage = "El campo {0} debe tener maximo {1}")]
       
        public string? Name { get; set; }

    }
}
