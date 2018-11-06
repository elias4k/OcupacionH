using Core.Abstract;
using Core.Entities;
using Data;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Concrete
{
    public class AlojamientoManager : IAlojamiento
    {
        private readonly AlojamientoDataBaseContext _context;

        public AlojamientoManager(AlojamientoDataBaseContext context)
        {
            _context = context;
        }

        public bool Add(AlojamientoEntity alojamiento)
        {
            var result = true;
            try
            {
                _context.Alojamientos.Add(new Alojamientos
                {
                    Id = alojamiento.Id,
                    Nombre = alojamiento.Nombre,
                    Clase = alojamiento.Clase,
                    Localidad = alojamiento.Localidad,
                    NroHab = alojamiento.NroHab,
                    NroHabOcupadas = alojamiento.NroHabOcupadas,
                    Plazas = alojamiento.Plazas,
                    PlazasOcupadas = alojamiento.PlazasOcupadas
                });
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                result = false;
            }

            return result;
        }

        public bool DeleteById(int id)

        {
            var result = false;

            try
            {
                var query = (from alojamiento in _context.Alojamientos
                             where alojamiento.Id.Equals(id)
                             select alojamiento).FirstOrDefault();

                //var lambdaExpression = _context.Alojamientos.FirstOrDefault(x => x.Id.Equals(id));

                if (query != null)
                {
                    //Remove indica si el elemento se elimino correctamente
                    //result = _context.Alojamientos.Remove(query);
                    _context.Alojamientos.Remove(query);

                    result = true;
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }

            return result;
        }

        public List<AlojamientoEntity> GetAll()

        {
            var result = new List<AlojamientoEntity>();

            try
            {
                var query = (from alj in _context.Alojamientos.ToList()
                             select new AlojamientoEntity
                             {
                                 Id = alj.Id,
                                 Nombre = alj.Nombre,
                                 Clase = alj.Clase,
                                 Localidad = alj.Localidad,
                                 NroHab = alj.NroHab,
                                 NroHabOcupadas = alj.NroHabOcupadas,
                                 Plazas = alj.Plazas,
                                 PlazasOcupadas = alj.PlazasOcupadas
                             }).ToList();

                if (query.Any())
                {
                    result.AddRange(query);
                }

            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }

            return result;
        }

        public AlojamientoEntity GetById(int id)
        {
            AlojamientoEntity result = null;

            try
            {
                var query = (from alojamiento in _context.Alojamientos
                             where alojamiento.Id.Equals(id)
                             select new AlojamientoEntity
                             {
                                 Id = alojamiento.Id,
                                 Nombre = alojamiento.Nombre,
                                 Clase = alojamiento.Clase,
                                 Localidad = alojamiento.Localidad,
                                 NroHab = alojamiento.NroHab,
                                 NroHabOcupadas = alojamiento.NroHabOcupadas,
                                 Plazas = alojamiento.Plazas,
                                 PlazasOcupadas = alojamiento.PlazasOcupadas
                             }).FirstOrDefault();

                if (query != null)
                {
                    result = query;
                }

            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }

            return result;
        }

        public bool Modify(AlojamientoEntity alojamiento)
        {
            var result = false;

            try
            {
                if (alojamiento != null)
                {
                    var query = _context.Alojamientos.FirstOrDefault(x => x.Id.Equals(alojamiento.Id));
                    var index = _context.Alojamientos.IndexOf(query);

                    if (index >= 0)
                    {
                        var aloj = new Alojamientos
                        {
                            Id = alojamiento.Id,
                            Nombre = alojamiento.Nombre,
                            Clase = alojamiento.Clase,
                            Localidad = alojamiento.Localidad,
                            NroHab = alojamiento.NroHab,
                            NroHabOcupadas = alojamiento.NroHabOcupadas,
                            Plazas = alojamiento.Plazas,
                            PlazasOcupadas = alojamiento.PlazasOcupadas
                        };

                        //_context.Alojamientos[index] = aloj;

                        //Como nada fallo, esto es correcto
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }

            return result;
        }
    }
}
