using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class UsuarioEntity
    {
        public string IdentityId { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Dni { get; set; }
        public String Email { get; set; }
        public DateTime FechaNac { get; set; }
    }
}
