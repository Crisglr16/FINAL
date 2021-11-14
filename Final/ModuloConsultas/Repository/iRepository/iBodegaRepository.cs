using ModuloConsultas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloConsultas.Repository.iRepository
{
    interface iBodegaRepository
    {
        ICollection<BodegaModel> GetBodegaModels();
        BodegaModel GetBodegaSalida(string nCodigoSalida);
        bool CrearBodega(BodegaModel bodega);
        bool ActualizarBodega(BodegaModel bodega);
        bool BorrarBodega(BodegaModel bodega);
        bool GuardarBodega();
    }
}
