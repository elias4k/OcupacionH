using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Reservas = new HashSet<Reservas>();
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Email { get; set; }
        public DateTime FechaNac { get; set; }
        public string IdentityId { get; set; }

        public ICollection<Reservas> Reservas { get; set; }
    }
}
