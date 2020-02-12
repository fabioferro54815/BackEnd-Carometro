using System;
using System.Collections.Generic;

namespace Senai.Carometro.WebApi.Domains
{
    public partial class Salas
    {
        public Salas()
        {
            Alunos = new HashSet<Alunos>();
        }

        public int IdSala { get; set; }
        public string Titulo { get; set; }
        public int IdTipoCurso { get; set; }
        public int IdCurso { get; set; }
        public int IdTermo { get; set; }
        public int IdTurno { get; set; }

        public Cursos IdCursoNavigation { get; set; }
        public Termos IdTermoNavigation { get; set; }
        public TipoCursos IdTipoCursoNavigation { get; set; }
        public Turnos IdTurnoNavigation { get; set; }
        public ICollection<Alunos> Alunos { get; set; }
    }
}
