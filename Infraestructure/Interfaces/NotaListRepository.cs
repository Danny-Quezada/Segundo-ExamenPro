using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Interfaces
{
    public class NotaListRepository : BaseRepository<Nota>, INotaRepository
    {


        // Aqui van a ir los metodos de IEstudianteRepository y ocupar la lista datos.
        public int CalcularPromedio()
        {
            return 1;
        }

        public ICollection<Nota> GetAsignaturas()
        {
            throw new NotImplementedException();
        }

        public ICollection<Estudiante> MejoresEstudiantes()
        {
            throw new NotImplementedException();
        }

        ICollection<Nota> INotaRepository.MejoresEstudiantes()
        {
            throw new NotImplementedException();
        }
    }
}
