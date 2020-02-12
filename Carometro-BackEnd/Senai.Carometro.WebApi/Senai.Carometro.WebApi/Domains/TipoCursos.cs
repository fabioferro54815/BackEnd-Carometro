using System;
using System.Collections.Generic;

namespace Senai.Carometro.WebApi.Domains
{
    public partial class TipoCursos
    {
        public TipoCursos()
        {
            Salas = new HashSet<Salas>();
        }

        public int IdTipoCurso { get; set; }
        public string Nome { get; set; }

        public ICollection<Salas> Salas { get; set; }
    }
}
