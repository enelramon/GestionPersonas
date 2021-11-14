using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonas.Entidades
{
    public class TipoAportes
    {
        [Key]
        public int TipoAporteId { get; set; }
        public string TipoAporte { get; set; }
        public float Valor { get; set; }
        public int AporteId { get; set; }
        public int PersonaId { get; set; }

        [ForeignKey("PersonaId")]
        public Personas Persona { get; set; }



        /*
        public TipoAportes(int TipoAporteId, string TipoAporte, float Valor)
        {
            this.TipoAporteId = TipoAporteId;
            this.TipoAporte = TipoAporte;
            this.Valor = Valor;
        }
        public TipoAportes()
        {

        }*/
    }
}
