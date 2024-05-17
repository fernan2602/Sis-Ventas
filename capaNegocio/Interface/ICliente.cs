using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using capaEntidad;

namespace capaNegocio.Interface
{
    internal interface ICliente
    {
        DataTable Listar();
        bool Agregar(cliente cliente);
        bool Eliminar(string cliente);
        bool Actualizar(cliente cliente);
        DataTable Buscar(string codCliente);


    }
}
