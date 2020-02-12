using System;
using System.Collections.Generic;

namespace Senai.Carometro.WebApi.Domains
{
    public partial class Alunos
    {
        public Alunos()
        {
            Ocorrecias = new HashSet<Ocorrecias>();
        }

        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public int NumeroMatricula { get; set; }
        public string Foto { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Rfid { get; set; }
        public int Idsala { get; set; }

        public Salas IdsalaNavigation { get; set; }
        public ICollection<Ocorrecias> Ocorrecias { get; set; }
    }
}
