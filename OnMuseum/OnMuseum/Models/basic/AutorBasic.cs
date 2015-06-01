using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnMuseum.Models.Basic
{
    public class AutorBasic
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Morte { get; set; }
        public string Biografia { get; set; }
    }
}