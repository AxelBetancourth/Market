﻿using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using CapaNegocio.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NUnidadMedidas
    {
        private DUnidadMedidas unidadMedidas;

        public NUnidadMedidas()
        {
            unidadMedidas = new DUnidadMedidas();
        }
        public List<MUnidadMedidas> TodasLasUnidades()
        {
            return unidadMedidas.UnidadesTodas();
        }
        public List<MUnidadMedidas> UnidadesActivas()
        {
            return unidadMedidas.UnidadesTodas().Where(c => c.Estado == true).ToList();
        }
        public int AgregarUnidades(MUnidadMedidas unidades)
        {
            unidades.FechaCreacion = DateTime.Now;
            return unidadMedidas.GuardarUnidades(unidades);
        }
        public int EditarUnidades(MUnidadMedidas unidades)
        {
            return unidadMedidas.GuardarUnidades(unidades);
        }
        public int EliminarUnidades(int unidadMedidaId)
        {
            return unidadMedidas.EliminarUnidades(unidadMedidaId);
        }

        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var unidades = TodasLasUnidades().Select(c => new
            {
                c.Descripción,
                c.UnidadMedidaId,
            }).ToList();
            foreach (var item in unidades)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.UnidadMedidaId,
                    Descripcion = item.Descripción
                });
            }

            return Datos;
        }
    }
}
