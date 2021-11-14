using ModuloConsultas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloConsultas.Repository.iRepository
{
    public interface iProdutoRepository
    {
        ICollection<ProductoModel> GetProductoModels();  
        ProductoModel GetProducto(int nCodigoProducto); 
        bool CrearProducto(ProductoModel producto); 
        bool ActualizarProducto(ProductoModel producto);
        bool BorrarProducto(ProductoModel producto);
        bool GuardarProducto(); 
    }
}
