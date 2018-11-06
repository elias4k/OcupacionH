using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Abstract
{
    public interface IAlojamiento
    {
        /// <summary>
        /// Agrega un Alojamiento
        /// </summary>
        /// <param name="alojamiento"></param>
        /// <returns></returns>
        bool Add(AlojamientoEntity alojamiento);

        /// <summary>
        /// Modifica los datos de un alojamiento
        /// </summary>
        /// <param name="alojamiento"></param>
        /// <returns></returns>
        bool Modify(AlojamientoEntity alojamiento);
        
        /// <summary>
        /// Elimina un alojamiento
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteById(int id);
        
        /// <summary>
        /// Busca un alojamiento
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AlojamientoEntity GetById(int id);
        
        /// <summary>
        /// Devielve una lista con todos los alojamientos
        /// </summary>
        /// <returns></returns>
        List<AlojamientoEntity> GetAll();
    }
}
