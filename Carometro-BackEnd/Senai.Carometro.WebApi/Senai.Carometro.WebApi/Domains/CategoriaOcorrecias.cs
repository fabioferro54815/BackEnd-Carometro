using System;
using System.Collections.Generic;

namespace Senai.Carometro.WebApi.Domains
{
    public partial class CategoriaOcorrecias
    {
        public CategoriaOcorrecias()
        {
            Ocorrecias = new HashSet<Ocorrecias>();
        }

        public int IdCategoriaOcorrecia { get; set; }
        public string Nome { get; set; }

        public ICollection<Ocorrecias> Ocorrecias { get; set; }
    }
}
