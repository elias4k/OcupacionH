 using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ReservaEntity
    {
        public int IdReservacion { get; set; }
        public int CantPlazas { get; set; }
        public int IdAlojamiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CantDias { get; set; }
        public DateTime FechaReserva { get; set; }
        public int DniUsuario { get; set; }
    }
}
