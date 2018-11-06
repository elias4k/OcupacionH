using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Abstract
{
    public interface IReserva
    {

        /// <summary>
        /// Agrega una Reserva
        /// </summary>
        /// <param name="reserva"></param>
        /// <returns></returns>
        bool Add(ReservaEntity reserva);

        /// <summary>
        /// Modifica los datos de una reserva
        /// </summary>
        /// <param name="reserva"></param>
        /// <returns></returns>
        bool Modify(ReservaEntity reserva);

        /// <summary>
        /// Da de baja una reserva
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteById(int id);

        /// <summary>
        /// Busca una reserva
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ReservaEntity GetById(int id);

        /// <summary>
        /// Devuelve una lista con todas las reservas
        /// </summary>
        /// <returns></returns>
        List<ReservaEntity> GetAll();
    }
}
