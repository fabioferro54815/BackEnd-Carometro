using Senai.Carometro.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Carometro.WebApi.Interfaces
{
    interface IAlunoRepositorio
    {
        List<Alunos> Listar();

        List<Alunos> ListarPorNome(string nome);

        void Cadastrar(Alunos aluno);

        void Atualizar(Alunos aluno);

        void Deletar(int id);
    }
}
