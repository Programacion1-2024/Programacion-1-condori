using CEntidades.Entidades;
using CLogica.Contracts;
using CDatos.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CLogica.Implementations
{
    public class GeneroLogic : IGeneroLogic
    {
        private readonly IRepository<Genero> _generoRepository;

        public GeneroLogic(IRepository<Genero> generoRepository)
        {
            _generoRepository = generoRepository;
        }

        public List<Genero> ObtenerGeneros()
        {
            return _generoRepository.FindAll().ToList();
        }

        public List<dynamic> ObtenerGenerosParaListado()
        {
            return _generoRepository.FindAll()
                .Select(g => new { IdGenero = g.IdGenero, Nombre = g.Nombre, Descripcion = g.Descripcion })
                .ToList<dynamic>();
        }

        public void AltaGenero(string nombre, string descripcion)
        {
            try
            {
                Genero generoNuevo = new Genero()
                {
                    Nombre = nombre,
                    Descripcion = descripcion
                };

                ValidarGenero(generoNuevo);

                _generoRepository.Create(generoNuevo);
                _generoRepository.Save();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de alta el género", ex);
            }
        }

        public void ActualizarGenero(int idGenero, string nombre, string descripcion)
        {
            try
            {
                Genero? genero = _generoRepository.GetById(idGenero);

                if (genero == null)
                {
                    throw new ArgumentNullException("No se encontró un género con el ID ingresado.");
                }

                genero.Nombre = nombre;
                genero.Descripcion = descripcion;

                ValidarGenero(genero);

                _generoRepository.Update(genero);
                _generoRepository.Save();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el género", ex);
            }
        }

        public void EliminarGenero(int idGenero)
        {
            Genero? genero = _generoRepository.GetById(idGenero);

            if (genero == null)
            {
                throw new ArgumentNullException("No se encontró un género con el ID ingresado.");
            }

            _generoRepository.Delete(genero);
            _generoRepository.Save();
        }

        public Genero? BuscarGenero(int idGenero)
        {
            return _generoRepository.GetById(idGenero);
        }

        #region validaciones

        private void ValidarGenero(Genero genero)
        {
            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(genero.Nombre))
                camposErroneos.Add("Nombre");
            if (string.IsNullOrEmpty(genero.Descripcion))
                camposErroneos.Add("Descripción");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: " + string.Join(", ", camposErroneos));
            }
        }

        #endregion
    }
}


