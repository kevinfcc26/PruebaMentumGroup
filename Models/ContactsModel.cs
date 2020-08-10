using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CustomerManager.Models
{
    public class ContactsModel
    {
        public int Id {get; set;}
        [StringLength(50)]
        [Required(ErrorMessage= "Este campo es obligatorio.")]
        [RegularExpression(@"^[A-Z a-z0-9ÑñáéíóúÁÉÍÓÚ\\-\\_]+$",
            ErrorMessage = "El Nombre debe ser alfanumérico.")]
        [Display(Name = "Name")]
        public string Name {get; set;}
        [StringLength(255)]
        [Required(ErrorMessage= "Este campo es obligatorio.")]
        [Display(Name = "Address")]
        public string Address {get; set;}
        [StringLength(10)]
        [Required(ErrorMessage= "Este campo es obligatorio.")]
        [Display(Name = "Phone")]
        public string Phone {get; set;}
        public int CustomerId {get; set;}
        public virtual CustomerModel Customer {get; set;}
    }
}