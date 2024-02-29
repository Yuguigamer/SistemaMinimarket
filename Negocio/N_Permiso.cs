using Dato;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Permiso
    {
        //devolver metodo listar de Usuario
        private D_Permiso objd_permiso = new D_Permiso();

        //Retornar  lista de Usuario de D_Usuario
        public List<Permiso> Listar(int IdUsuario)
        {
            return objd_permiso.Listar(IdUsuario);

        }
    }
}
