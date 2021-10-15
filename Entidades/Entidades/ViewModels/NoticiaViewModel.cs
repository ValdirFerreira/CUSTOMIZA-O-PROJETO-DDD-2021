using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.ViewModels
{
    public class NoticiaViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Informacao { get; set; }
        public string DataCadastro { get; set; }
        public string Usuario { get; set; }
    }
}
