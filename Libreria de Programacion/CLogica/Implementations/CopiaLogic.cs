using CEntidades.Entidades;
using CDatos.Repositories.Contracts;
using CLogica.Contracts;

public class CopiaLogic : ICopiaLogic
{
    private readonly ICopiaRepository _copiaRepository;

    public CopiaLogic(ICopiaRepository copiaRepository)
    {
        _copiaRepository = copiaRepository;
    }


    public List<Copia> ObtenerCopias()
    {
        return _copiaRepository.FindAll().ToList();
    }
    public List<dynamic> ObtenerCopiasParaListado()
    {
        return _copiaRepository.FindAll()
            .Select(c => new { IdCopia = c.IdCopia, PrecioPrestamo = c.PrecioPrestamo, NombreLibro = c.Libro.Titulo })
            .ToList<dynamic>();
    }
    public List<Copia> ObtenerCopiasConLibro()
    {
        return _copiaRepository.ObtenerCopiasConLibro();
    }

    public List<Copia> ObtenerCopiasConPrestamos()
    {
        return _copiaRepository.ObtenerCopiasConPrestamos();
    }

    public void AltaCopia(float precioPrestamo, Libro libro)
    {
        Copia nuevaCopia = new Copia
        {
            PrecioPrestamo = precioPrestamo,
            Libro = libro
        };

        List<string> camposErroneos = ValidarCopia(nuevaCopia);

        if (camposErroneos.Count > 0)
        {
            throw new ArgumentException("Los siguientes campos son inválidos: " + string.Join(", ", camposErroneos));
        }

        _copiaRepository.Create(nuevaCopia);
        _copiaRepository.Save();
    }

    public void ActualizarCopia(int idCopia, float nuevoPrecioPrestamo, Libro nuevoLibro)
    {
        Copia? copiaExistente = _copiaRepository.GetById(idCopia);

        if (copiaExistente == null)
        {
            throw new ArgumentNullException("No se encontró la copia con el ID proporcionado.");
        }

        copiaExistente.PrecioPrestamo = nuevoPrecioPrestamo;
        copiaExistente.Libro = nuevoLibro;

        List<string> camposErroneos = ValidarCopia(copiaExistente);

        if (camposErroneos.Count > 0)
        {
            throw new ArgumentException("Los siguientes campos son inválidos: " + string.Join(", ", camposErroneos));
        }

        _copiaRepository.Update(copiaExistente);
        _copiaRepository.Save();
    }


    public void EliminarCopia(int idCopia)
    {
        Copia? copiaExistente = _copiaRepository.GetById(idCopia);

        if (copiaExistente == null)
        {
            throw new ArgumentNullException("No se encontró la copia con el ID proporcionado.");
        }

        _copiaRepository.Delete(copiaExistente);
        _copiaRepository.Save();
    }
    public Copia? ObtenerCopiaPorId(int idCopia)
    {
        return _copiaRepository.GetById(idCopia);
    }
    #region validaciones
    private List<string> ValidarCopia(Copia copia)
    {
        List<string> camposErroneos = new List<string>();

        if (copia.PrecioPrestamo <= 0)
            camposErroneos.Add("PrecioPrestamo debe ser mayor que cero.");

        if (copia.Libro == null)
            camposErroneos.Add("El libro asociado no puede ser nulo.");

        return camposErroneos;
    }

    public bool IsValidPrecioPrestamo(float precioPrestamo)
    {
        return precioPrestamo > 0;
    }
    #endregion validaciones

}

