using Senai.Carometro.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Carometro.WebApi.Interfaces
{
    interface ICursoRepositorio
    {
        void Cadastrar(Cursos curso);

        void Atualizar(Cursos curso);

        void Deletar(int id);
    }
}
