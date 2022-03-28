using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "O sobrenome é requerido.")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O email é requerido.")]

        [Display(Name = "Data de Cadastro")]
        public string DateCreate { get; set; }
        [Required(ErrorMessage = "A data é requerida.")]
       
        

        [Display(Name = "Ativo")]
        public bool Ative { get; set; }
    }
}
