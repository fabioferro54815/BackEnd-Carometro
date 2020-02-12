using Senai.Carometro.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Carometro.WebApi.Interfaces
{
    interface IOcorrenciaRepositorio
    {
        List<Ocorrecias> Listar();

        List<Ocorrecias> ListarPorCategoria(string categoria);

        void Cadastrar(Ocorrecias ocorrecia);

        void Atualizar(Ocorrecias ocorrecia);

        void Deletar(int id);
    }
}
