using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Alojamientos
    {
        public Alojamientos()
        {
            ReservasNavigation = new HashSet<Reservas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public string Clase { get; set; }
        public int NroHab { get; set; }
        public int NroHabOcupadas { get; set; }
        public int Plazas { get; set; }
        public int PlazasOcupadas { get; set; }
        public int Reservas { get; set; }

        public ICollection<Reservas> ReservasNavigation { get; set; }
    }
}
