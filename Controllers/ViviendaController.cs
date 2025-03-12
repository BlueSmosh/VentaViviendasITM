using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VentaViviendasITM.Class;
using VentaViviendasITM.Models;

namespace VentaViviendasITM.Controllers
{
    [RoutePrefix("api/vivienda")]
    public class ViviendaController : ApiController
    {
        [HttpGet]
        [Route("Listar")]
        public List<Vivienda> Listar()
        {
            clsViviendas objViviendas = new clsViviendas();
            return objViviendas.ListarTodo();
        }
        [HttpGet]
        [Route("BuscarPorID")]
        public Vivienda BuscarPorID(int id)
        {
            clsViviendas objViviendas = new clsViviendas();
            return objViviendas.BuscarPorID(id);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody]Vivienda vivienda)
        {
            clsViviendas objViviendas = new clsViviendas();
            objViviendas.vivienda = vivienda;
            return objViviendas.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody]Vivienda vivienda)
        {
            clsViviendas objViviendas = new clsViviendas();
            objViviendas.vivienda = vivienda;
            return objViviendas.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Vivienda vivienda)
        {
            clsViviendas objViviendas = new clsViviendas();
            objViviendas.vivienda = vivienda;
            return objViviendas.Eliminar();
        }
    }
}