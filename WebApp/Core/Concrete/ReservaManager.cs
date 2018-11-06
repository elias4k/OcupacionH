using Core.Abstract;
using Core.Entities;
using Data;
using Microsoft.EntityFrameworkCore.Internal;
//using Data;
//using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Concrete
{
    public class ReservaManager : IReserva
    {
        private readonly AlojamientoDataBaseContext _context;

        public ReservaManager(AlojamientoDataBaseContext context)
        {
            _context = context;
        }

        public bool Add(ReservaEntity reserva)
        {
            var result = true;

            try
            {
                _context.Reservas.Add(new Reservas
                {
                    IdReservacion = reserva.IdReservacion,
                    CantPlazas = reserva.CantPlazas,
                    IdAlojamiento = reserva.IdAlojamiento,
                    FechaIngreso = reserva.FechaIngreso,
                    CantDias = reserva.CantDias,
                    FechaReserva = reserva.FechaReserva,
                    DniUsuario = reserva.DniUsuario
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
                var query = (from reserva in _context.Reservas
                             where reserva.IdReservacion.Equals(id)
                             select reserva).FirstOrDefault();

                if (query != null)
                {
                    _context.Reservas.Remove(query);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }

            return result;
        }

        public List<ReservaEntity> GetAll()
        {
            var result = new List<ReservaEntity>();

            try
            {
                var query = (from reserva in _context.Reservas
                             select new ReservaEntity
                             {
                                 IdReservacion = reserva.IdReservacion,
                                 CantPlazas = reserva.CantPlazas,
                                 IdAlojamiento = reserva.IdAlojamiento,
                                 FechaIngreso = reserva.FechaIngreso,
                                 CantDias = reserva.CantDias,
                                 FechaReserva = reserva.FechaReserva,
                                 DniUsuario = reserva.DniUsuario
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

        public ReservaEntity GetById(int id)
        {
            ReservaEntity result = null;

            try
            {
                var query = (from reserva in _context.Reservas
                             where reserva.IdReservacion.Equals(id)
                             select new ReservaEntity
                             {
                                 IdReservacion = reserva.IdReservacion,
                                 CantPlazas = reserva.CantPlazas,
                                 IdAlojamiento = reserva.IdAlojamiento,
                                 FechaIngreso = reserva.FechaIngreso,
                                 CantDias = reserva.CantDias,
                                 FechaReserva = reserva.FechaReserva,
                                 DniUsuario = reserva.DniUsuario
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

        public bool Modify(ReservaEntity reserva)
        {
            var result = false;

            try
            {
                if (reserva != null)
                {
                    var query = _context.Reservas.FirstOrDefault(x => x.IdReservacion.Equals(reserva.IdReservacion));
                    var index = _context.Reservas.IndexOf(query);

                    if (index >= 0)
                    {
                        var reser = new Reservas
                        {
                            IdReservacion = reserva.IdReservacion,
                            CantPlazas = reserva.CantPlazas,
                            IdAlojamiento = reserva.IdAlojamiento,
                            FechaIngreso = reserva.FechaIngreso,
                            CantDias = reserva.CantDias,
                            FechaReserva = reserva.FechaReserva,
                            DniUsuario = reserva.DniUsuario
                        };

                        //_context.Reservas[index] = reser;

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
