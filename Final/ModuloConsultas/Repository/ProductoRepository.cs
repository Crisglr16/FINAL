using ModuloConsultas.Connection;
using ModuloConsultas.Models;
using ModuloConsultas.Repository.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ModuloConsultas.Repository
{
    public class ProductoRepository: iProdutoRepository
    {
        private readonly Conn _db;

       public ProductoRepository(Conn db) 
        {
            _db = db;
        }

        public bool ActualizarProducto(ProductoModel producto)
        {
            _db.Productos.Update(producto);
            return GuardarProducto();
        }

        public bool BorrarProducto(ProductoModel producto)
        {
            _db.Productos.Remove(producto);
            return GuardarProducto();
        }

        public bool CrearProducto(ProductoModel producto)
        {
            _db.Productos.Add(producto);
            return GuardarProducto();
        }

        public ProductoModel GetProducto(int nCodigoProducto)
        {
            return _db.Productos.FirstOrDefault(produc => produc.CodigoProducto == nCodigoProducto);
        }

        public ICollection<ProductoModel> GetProductoModels()
        {
            return _db.Productos.OrderBy(produc => produc.NombreProducto).ToList();
        }

        public bool GuardarProducto()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
