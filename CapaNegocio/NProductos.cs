﻿using CapaDatos.BaseDatos.Modelos;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio.Comun;

namespace CapaNegocio
{
    public class NProductos
    {

        private DProductos dproductos;

        public NProductos()
        {
            dproductos = new DProductos();
        }

        public List<MProductos> TodosProductos()
        {
            return dproductos.TodosLosProductos();
        }
        public int AgregarProducto(MProductos Productos)
        {
            Productos.FechaCreacion = DateTime.Now;
            return dproductos.Guardar(Productos);
        }
        public int EditarProducto(MProductos Productos)
        {

            return dproductos.Guardar(Productos);
        }

        public int EliminarProductos(int ProductoId)
        {
            return dproductos.Eliminar(ProductoId);
        }
        public List<object> obtenerProductosGrid()
        {
            var productos = dproductos.TodosLosProductos().Select(c => new {
                c.ProductoId,
                CategoriaDescripcion = c.MCategorias.Descripción,
                UnidadMedidaDescripcion = c.MUnidadMedidas.Descripción,
                c.Estado,
                c.PrecioCompra,
                c.FechaCreacion
            });
            return productos.Cast<object>().ToList();
        }

        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var pedidos = TodosProductos().Select(c => new
            {
                c.ProductoId
            }).ToList();
            foreach (var item in pedidos)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.ProductoId,
                });
            }
            return Datos;
        }
        public List<object> obtenerProductosActivosGrid()
        {
            var productos = dproductos.TodosLosProductos().Select(c => new {
                c.ProductoId,
                CategoriaDescripcion = c.MCategorias.Descripción,
                UnidadMedidaDescripcion = c.MUnidadMedidas.Descripción,
                c.Estado,
                c.PrecioCompra,
                c.FechaCreacion
            }).Where(c => c.Estado == true);
            return productos.Cast<object>().ToList();
        }
        public List<object> BuscarProductosGrid()
        {
            var productos = dproductos.TodosLosProductos().Select(c => new {
                c.ProductoId,
                c.CategoriaId,
                CategoriaDescripcion = c.MCategorias.Descripción,
                c.UnidadMedidaId,
                UnidadMedidaDescripcion = c.MUnidadMedidas.Descripción,
                c.PrecioCompra,
                c.Estado
            });
            return productos.Cast<object>().ToList();
        }
        public List<object> BuscarProductosGridactivos()
        {
            var productos = dproductos.TodosLosProductos().Select(c => new {
                c.ProductoId,
                c.CategoriaId,
                CategoriaDescripcion = c.MCategorias.Descripción,
                c.UnidadMedidaId,
                UnidadMedidaDescripcion = c.MUnidadMedidas.Descripción,
                c.PrecioCompra,
                c.Estado
            }).Where(c => c.Estado == true);
            return productos.Cast<object>().ToList();
        }
    }
}

