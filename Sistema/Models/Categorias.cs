using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Models
{
    public class Categorias
    {   
        [Key]
        public int CategoriaId { get; set; }
        [Required (ErrorMessage ="Campo Obligatorio!.")]
        [StringLength(50,MinimumLength = 3,ErrorMessage ="El nombre ingresado es invalido.")]
        public string Nombre { get; set; }
        [StringLength(256, ErrorMessage ="La descripcion supera los 256 caracteres.")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
