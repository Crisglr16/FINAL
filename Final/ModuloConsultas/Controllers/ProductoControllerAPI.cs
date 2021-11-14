using AutoMapper;
using ModuloConsultas.Repository.iRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModuloConsultas.Repository;

namespace ModuloConsultas.Controllers
{
    [Route ("api/Producto")]
    public class ProductoControllerAPI:Controller
    {
        private readonly iProdutoRepository _ctoproductos;
        private readonly IMapper _mapper;

        public ProductoControllerAPI(ProductoRepository ctoproductos, IMapper mapper)
        {
            _ctoproductos = ctoproductos;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ListaProducto()
        {
            var nListarProducto = _ctoproductos.GetProductoModels();
            foreach (var nListar in nListarProducto)
            {

            }
            return Ok(nListarProducto);
        }
    }
}
