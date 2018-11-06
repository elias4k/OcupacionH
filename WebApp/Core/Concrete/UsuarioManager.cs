using Core.Abstract;
using Core.Entities;
using Data;
using Microsoft.EntityFrameworkCore.Internal;
//using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Concrete
{
    public class UsuarioManager : IUsuario
    {
        private readonly AlojamientoDataBaseContext _context;

        public UsuarioManager(AlojamientoDataBaseContext context)
        {
            _context = context;
        }

            public bool Add(UsuarioEntity usuario)
        {
            var result = true;

            try
            {
                _context.Usuarios.Add(new Usuarios
                {
                    Nombre = usuario.Nombre,
                    Apellido = usuario.Apellido,
                    Dni = usuario.Dni,
                    Email = usuario.Email,
                    FechaNac = usuario.FechaNac,

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
                var query = (from usuario in _context.Usuarios
                             where usuario.Dni.Equals(id)
                             select usuario).FirstOrDefault();

                if (query != null)
                {
                    _context.Usuarios.Remove(query);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }

            return result;
        }

        public List<UsuarioEntity> GetAll()
        {
            var result = new List<UsuarioEntity>();

            try
            {
                var query = (from usuario in _context.Usuarios
                             select new UsuarioEntity
                             {
                                 Nombre = usuario.Nombre,
                                 Apellido = usuario.Apellido,
                                 Dni = usuario.Dni,
                                 Email = usuario.Email,
                                 FechaNac = usuario.FechaNac,
                                 IdentityId = usuario.IdentityId
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

        public UsuarioEntity GetById(int id)
        {
            UsuarioEntity result = null;

            try
            {
                var query = (from usuario in _context.Usuarios
                             where usuario.Dni.Equals(id)
                             select new UsuarioEntity
                             {
                                 Nombre = usuario.Nombre,
                                 Apellido = usuario.Apellido,
                                 Dni = usuario.Dni,
                                 Email = usuario.Email,
                                 FechaNac = usuario.FechaNac,
                                 //IdentityId = usuario.IdentityId
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

        public bool Modify(UsuarioEntity usuario)
        {
            var result = false;

            try
            {
                if (usuario != null)
                {
                    var query = _context.Usuarios.FirstOrDefault(x => x.Dni.Equals(usuario.Dni));
                    var index = _context.Usuarios.IndexOf(query);

                    if (index >= 0)
                    {
                        var reser = new Usuarios
                        {
                            Nombre = usuario.Nombre,
                            Apellido = usuario.Apellido,
                            Dni = usuario.Dni,
                            Email = usuario.Email,
                            FechaNac = usuario.FechaNac,
                            IdentityId = usuario.IdentityId
                        };

                        //_context.Usuarios[index] = reser;

                        //como nada fallo, esto es correcto
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


