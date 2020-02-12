using System;
using System.Collections.Generic;

namespace Senai.Carometro.WebApi.Domains
{
    public partial class Turnos
    {
        public Turnos()
        {
            Salas = new HashSet<Salas>();
        }

        public int IdTurno { get; set; }
        public string Nome { get; set; }

        public ICollection<Salas> Salas { get; set; }
    }
}
