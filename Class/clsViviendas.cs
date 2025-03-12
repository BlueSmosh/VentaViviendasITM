using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using VentaViviendasITM.Models;

namespace VentaViviendasITM.Class
{
    public class clsViviendas
    {
        private VentaViviendasITMEntities ventaViviendasITM = new VentaViviendasITMEntities();
        public Vivienda vivienda { get; set; }

        public string Insertar()
        {
            try
            {
                ventaViviendasITM.Viviendas.Add(vivienda); 
                ventaViviendasITM.SaveChanges(); 
                return "Vivienda registrada con exito"; 
            }
            catch (Exception ex)
            {
                return "Error al registrar el Vivienda: " + ex.Message; 
            }
        }
        public string Actualizar()
        {
            try
            {
                Vivienda vivi = BuscarPorID(vivienda.ViviendaID);
                if (vivi == null)
                {
                    return "Vivienda no existe";
                }
                ventaViviendasITM.Viviendas.AddOrUpdate(vivienda); 
                ventaViviendasITM.SaveChanges();
                return "Vivienda actualizada con exito";

            }
            catch (Exception ex)
            {
                return "Error al actualizar el Vivienda: " + ex.Message;
            }
        }
        public Vivienda BuscarPorID(int id)
        {
            Vivienda vivi = ventaViviendasITM.Viviendas.FirstOrDefault(v => v.ViviendaID == id); //.Find(id);
            return vivi;
        }
        public List<Vivienda> ListarTodo()
        {
            return ventaViviendasITM.Viviendas.ToList();
        }
        public string Eliminar() 
        {
            try
            {
                Vivienda vivi = BuscarPorID(vivienda.ViviendaID);
                if (vivi == null)
                {
                    return "Vivienda no existe";
                }
                ventaViviendasITM.Viviendas.Remove(vivi);
                ventaViviendasITM.SaveChanges();
                return "Vivienda eliminada";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Vivienda: " + ex.Message;
            }
        }
    }
}