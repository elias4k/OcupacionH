using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class AlojamientoEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public string Clase { get; set; }
        public int NroHab { get; set; }
        public int NroHabOcupadas { get; set; }
        public int Plazas { get; set; }
        public int PlazasOcupadas { get; set; }
        public int Reservas { get; set; }


        public override string ToString()
        {
            return $"Mi {Clase} de la localidad de {Localidad} tiene {NroHabOcupadas} con un total de {PlazasOcupadas} Plazas ocupadas";
        }
    }
}
