using Senai.Carometro.WebApi.Domains;
using Senai.Carometro.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Carometro.WebApi.Interfaces
{
    interface IUsuarioRepositorio
    {
        void Cadastrar(Usuarios usuario);

        Usuarios RealizarLogin(LoginViewModel login);

        void Deletar(int id);
    }
}
