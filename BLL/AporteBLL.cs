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
    public class AporteBLL
    {
        public static bool Guardar(Aportes aportes)
        {
            if (!Existe(aportes.AporteId))//si no existe insertamos
                return Insertar(aportes);
            else
                return Modificar(aportes);
        }
        private static bool Insertar(Aportes aportes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //Agregar la entidad que se desea insertar al contexto
                contexto.Aportes.Add(aportes);

                foreach (var detalle in aportes.Detalle)
                {
                    detalle.Persona.CantidadGrupos += 1;
                    
                }

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
        private static bool Modificar(Aportes aportes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
               var AporteAnterior = contexto.Aportes
                    .Where(x => x.AporteId == aportes.AporteId)
                    .Include(x => x.Detalle)
                    .ThenInclude(x => x.Persona)
                    .AsNoTracking()
                    .SingleOrDefault();

                //busca la entidad en la base de datos y la elimina
                foreach (var detalle in AporteAnterior.Detalle)
                {
                    detalle.Persona.CantidadGrupos -= 1;
                }

                contexto.Database.ExecuteSqlRaw($"Delete FROM Personas Where AporteId={aportes.AporteId}");

                foreach (var item in aportes.Detalle)
                {
                    item.Persona.CantidadGrupos += 1;
                    contexto.Entry(item).State = EntityState.Added;
                }

                //marcar la entidad como modificada para que el contexto sepa como proceder
                contexto.Entry(aportes).State = EntityState.Modified;
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
                //buscar la entidad que se desea eliminar
               var aporte = AporteBLL.Buscar(id);

               if(aporte != null)
               {
                    //busca la entidad en la base de datos y la elimina
                    foreach (var detalle in aporte.Detalle)
                    {
                        detalle.Persona.CantidadGrupos -= 1;
                    }

                    contexto.Aportes.Remove(aporte); //remover la entidad
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
        public static Aportes Buscar(int id)
        {
            Aportes aportes = new Aportes();
            Contexto contexto = new Contexto();

            try
            {

               //aportes= contexto.Aportes.Find(id);
               aportes = contexto.Aportes.Include(x => x.Detalle)
                    .Where(x => x.AporteId == id)
                     .Include(x => x.Detalle)
                    .ThenInclude(x => x.Persona)
                    .SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return aportes;
        }
        public static List<Aportes> GetList(Expression<Func<Aportes, bool>> criterio)
        {
            List<Aportes> Lista = new List<Aportes>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla según el criterio recibido por parametro.
                Lista = contexto.Aportes.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Aportes.Any(e => e.AporteId == id);
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

        
    }
}
