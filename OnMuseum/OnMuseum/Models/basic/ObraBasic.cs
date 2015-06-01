using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnMuseum.Models.Basic
{
    public class ObraBasic
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required]
        [DisplayName("Autor")]
        public int AutorId { get; set; }
        [DisplayName("Criação")]
        public string Criacao { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Entrada")]
        public DateTime Entrada { get; set; }

        [DisplayName("Observações")]
        public string Observacao { get; set; }

        public virtual AutorBasic Autor { get; set; }

    }
}