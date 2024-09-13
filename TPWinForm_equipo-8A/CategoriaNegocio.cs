﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_8A
{
    class CategoriaNegocio
    {
        public List<Categoria> listar()
         {
             List<Categoria> lista = new List<Categoria>();
             AccesoDatos datos = new AccesoDatos();

             try
             {
                 datos.setearConsulta("select id, descripcion from CATEGORIAS");
                 datos.ejecutarLectura();

                 while (datos.Lector.Read())
                 {
                     Categoria categoria = new Categoria();
                     categoria.Id = (int)datos.Lector["id"];
                     categoria.Nombre = datos.Lector["descripcion"].ToString();

                     lista.Add(categoria);
                 }
                 return lista;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 datos.cerrarConexion();
             }
         }

         /// agregar o eliminar categorias de la bd
         public void agregar(Categoria nuevaCategoria)
         {
             AccesoDatos datos = new AccesoDatos();

             try
             {
                 datos.setearConsulta("INSERT INTO CATEGORIAS (descripcion) VALUES (@descripcion)");
                 datos.SetearParametro("@descripcion", nuevaCategoria.Nombre);
                 datos.ejecutarAccion();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 datos.cerrarConexion();
             }
         }

         public void eliminar(int id)
         {
             AccesoDatos datos = new AccesoDatos();

             try
             {
                 datos.setearConsulta("DELETE FROM CATEGORIAS WHERE id = @id");
                 datos.SetearParametro("@id", id);
                 datos.ejecutarAccion();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 datos.cerrarConexion();
             }
         }

       







    }
}

