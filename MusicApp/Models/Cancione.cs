using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public partial class Cancione
    {
        [Key]
        public int IdCancion { get; set; }
        [Display(Name = "Link:")]
        public string Link { get; set; } = null!;
        [Display(Name = "Titulo:")]
        [Required(ErrorMessage = "Ingresa un titulo")]
        public string Titulo { get; set; } = null!;
        [Display(Name = "Grupo:")]
        [Required(ErrorMessage = "Ingresa un grupo")]
        public string Grupo { get; set; } = null!;
        [Display(Name = "Año:")]
        [Required(ErrorMessage = "Ingresa un año")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "El Año debe tener 4 caracteres")]
        public string Año { get; set; } = null!;
        [Display(Name = "Genero:")]
        [Required(ErrorMessage = "Ingresa un genero")]        
        public string Genero { get; set; } = null!;
    }
}
