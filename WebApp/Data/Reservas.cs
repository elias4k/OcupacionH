using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Reservas
    {
        public int IdReservacion { get; set; }
        public int CantPlazas { get; set; }
        public int IdAlojamiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CantDias { get; set; }
        public DateTime FechaReserva { get; set; }
        public int DniUsuario { get; set; }

        public Usuarios DniUsuarioNavigation { get; set; }
        public Alojamientos IdAlojamientoNavigation { get; set; }
    }
}
