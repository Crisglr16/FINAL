using ModuloConsultas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloConsultas.Repository.iRepository
{
    interface iProveedorRepository
    {
        ICollection<ProveedorModel> GetProveedorModels();
        ProveedorModel GetProveedorCodigo(string nCodigoProveedor);
        bool CrearProveedor(ProveedorModel proveedor);
        bool ActualizarProducto(ProveedorModel proveedor);
        bool BorrarProducto(ProveedorModel proveedor);
        bool GuardarProducto();

    }
}
