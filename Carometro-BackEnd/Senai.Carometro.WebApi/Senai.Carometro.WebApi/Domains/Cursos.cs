using System;
using System.Collections.Generic;

namespace Senai.Carometro.WebApi.Domains
{
    public partial class Cursos
    {
        public Cursos()
        {
            Salas = new HashSet<Salas>();
        }

        public int IdCurso { get; set; }
        public string Nome { get; set; }

        public ICollection<Salas> Salas { get; set; }
    }
}
