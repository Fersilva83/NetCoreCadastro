 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace Cadastro.ViewModels
{
    public class ProdutoViewModel
    {

        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome do produto é requerido.")]
        public string NameProduct { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O preço/valor é requerido.")]
        public double Valor { get; set; }

        [Display(Name = "Ativo")]
        public bool Ative { get; set; }

        
    }
}
