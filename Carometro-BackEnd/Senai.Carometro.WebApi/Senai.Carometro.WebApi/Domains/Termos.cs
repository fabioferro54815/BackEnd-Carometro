using System;
using System.Collections.Generic;

namespace Senai.Carometro.WebApi.Domains
{
    public partial class Termos
    {
        public Termos()
        {
            Salas = new HashSet<Salas>();
        }

        public int IdTermo { get; set; }
        public string Nome { get; set; }

        public ICollection<Salas> Salas { get; set; }
    }
}
