using Senai.Carometro.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Carometro.WebApi.Interfaces
{
    interface ISalaRepositorio
    {
        void Cadastrar(Salas sala);

        void Deletar(int id);
    }
}
