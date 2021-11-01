using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonas.Entidades
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Concepto { get; set; }
        public float Monto { get; set; }

        [ForeignKey("AporteId")]
        public List<TipoAportes> Detalle { get; set; } = new List<TipoAportes>();




        //public int TipoAporteId { get; set; }

        //AporteId,Fecha,PersonaId,Concepto, Monto

        /*[ForeignKey("PersonaId")]
        public Personas Persona { get; set; }


        [ForeignKey("AporteId")]
        public TipoAportes Tipo { get; set; }

        public List<Aportes> Lista { get; set; } = new List<Aportes>();*/
        /*
        public Aportes(int AporteId, DateTime Fecha, int PersonaId, string Concepto, float Monto)
        {
            this.AporteId = AporteId;
            this.Fecha = Fecha;
            this.PersonaId = PersonaId;
            this.Concepto = Concepto;
            this.Monto = Monto;
            //this.TipoAporteId = TipoAporteId;
        }
        public Aportes()
        {

        }
        */
    }
}
