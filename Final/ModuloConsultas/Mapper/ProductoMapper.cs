using AutoMapper;
using ModuloConsultas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloConsultas.Mapper
{
    public class ProductoMappers:Profile
    {
        public ProductoMappers()
        {
            _ = CreateMap<ProductoModel>();
        }

        private object CreateMap<T>()
        {
            throw new NotImplementedException();
        }
    }
}
