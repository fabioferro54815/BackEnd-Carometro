using System;
using System.Collections.Generic;

namespace Senai.Carometro.WebApi.Domains
{
    public partial class Ocorrecias
    {
        public int IdOcorrecia { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public bool? Falta { get; set; }
        public string Cid { get; set; }
        public int IdUsuario { get; set; }
        public int IdAluno { get; set; }
        public int IdCategoriaOcorrencia { get; set; }

        public Alunos IdAlunoNavigation { get; set; }
        public CategoriaOcorrecias IdCategoriaOcorrenciaNavigation { get; set; }
        public Usuarios IdUsuarioNavigation { get; set; }
    }
}
