using GestionPersonas.DAL;
using GestionPersonas.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonas.BLL
{
    public class TipoAporteBLL
    {
        /*
        public static bool Guardar(TipoAportes tipoAportes)
        {
            if (!Existe(tipoAportes.TipoAporteId))
            {
                return Insertar(tipoAportes);
            }
            else
            {
                return Modificar(tipoAportes);
            }
        }
        private static bool Insertar(TipoAportes tipoAportes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //Agregar la entidad que se desea insertar al contexto
                contexto.TipoAportes.Add(tipoAportes);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        public static bool Modificar(TipoAportes tipoAportes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(tipoAportes).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var tipoAportes = contexto.TipoAportes.Find(id);

                if (tipoAportes != null)
                {
                    contexto.TipoAportes.Remove(tipoAportes);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static TipoAportes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TipoAportes tipoAportes;

            try
            {
                tipoAportes = contexto.TipoAportes.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tipoAportes;
        }
        public static List<TipoAportes> GetList(Expression<Func<TipoAportes, bool>> criterio)
        {
            List<TipoAportes> lista = new List<TipoAportes>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.TipoAportes.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.TipoAportes.Any(r => r.TipoAporteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }
        public static bool ExisteDescripcion(string descripcion)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Roles.Any(r => r.Descripcion == descripcion);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }
        public static List<TipoAportes> GetRoles()
        {
            List<TipoAportes> lista = new List<TipoAportes>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.TipoAportes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
        public static List<TipoAportes> GetTipoAporte()
        {
            List<TipoAportes> lista = new List<TipoAportes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TipoAportes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
     
        }
        */
    }
}
