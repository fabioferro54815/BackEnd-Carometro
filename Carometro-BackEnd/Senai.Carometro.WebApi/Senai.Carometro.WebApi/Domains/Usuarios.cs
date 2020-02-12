using System;
using System.Collections.Generic;

namespace Senai.Carometro.WebApi.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Ocorrecias = new HashSet<Ocorrecias>();
        }

        public int IdUsuario { get; set; }
        public int Nif { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool? TipoUsuario { get; set; }

        public ICollection<Ocorrecias> Ocorrecias { get; set; }
    }
}
