using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dato;
using Entidad;

namespace Negocio
{
    public class N_Usuario
    {
        //devolver metodo listar de Usuario
        private D_Usuario objd_usuario = new D_Usuario();

        //Retornar  lista de Usuario de D_Usuario
        public List<Usuario> Listar()
        {
            return objd_usuario.Listar();

        }
    }
}
