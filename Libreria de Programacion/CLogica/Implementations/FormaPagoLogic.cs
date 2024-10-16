using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class FormaPagoLogic : IFormaPagoLogic
    {
        private IFormaPagoRepository _formaPagoRepository;

        public FormaPagoLogic(IFormaPagoRepository formaPagoRepository)
        {
            _formaPagoRepository = formaPagoRepository;
        }

        public List<FormaPago> ObtenerFormasPago()
        {
            return _formaPagoRepository.FindAll().ToList();
        }

        public List<dynamic> ObtenerFormasPagoParaListado()
        {
            return _formaPagoRepository.FindAll()
                .Select(f => new
                {
                    IdFormaPago = f.IdFormaPago,
                    Descripcion = f.Descripcion
                })
                .ToList<dynamic>();
        }

        public void AltaFormaPago(string descripcion)
        {
            try
            {
                FormaPago nuevaFormaPago = new FormaPago()
                {
                    Descripcion = descripcion,
                };

                List<string> camposErroneos = ValidarFormaPago(nuevaFormaPago);

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: " + string.Join(", ", camposErroneos));
                }

                _formaPagoRepository.Create(nuevaFormaPago);
                _formaPagoRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarFormaPago(int idFormaPago, string descripcion)
        {
            try
            {
                FormaPago? formaPago = _formaPagoRepository.GetById(idFormaPago);

                if (formaPago == null)
                {
                    throw new ArgumentNullException("No se encontró una forma de pago con el ID ingresado.");
                }

                formaPago.Descripcion = descripcion;

                List<string> camposErroneos = ValidarFormaPago(formaPago);

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: " + string.Join(", ", camposErroneos));
                }

                _formaPagoRepository.Update(formaPago);
                _formaPagoRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarFormaPago(int idFormaPago)
        {
            FormaPago? formaPago = _formaPagoRepository.GetById(idFormaPago);

            if (formaPago == null)
            {
                throw new ArgumentNullException("No se encontró una forma de pago con el ID ingresado.");
            }

            _formaPagoRepository.Delete(formaPago);
            _formaPagoRepository.Save();
        }

        public FormaPago? BuscarFormaPago(int idFormaPago) => _formaPagoRepository.GetById(idFormaPago);

        #region validaciones
        private List<string> ValidarFormaPago(FormaPago formaPago)
        {
            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(formaPago.Descripcion) || !IsValidDescripcion(formaPago.Descripcion))
                camposErroneos.Add("Descripcion");

            return camposErroneos;
        }

        private bool ContainsInvalidCharacter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }

        public bool IsValidDescripcion(string descripcion)
        {
            return descripcion.Length <= 100 && !ContainsInvalidCharacter(descripcion);
        }
        #endregion validaciones
    }

}
