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

        public Nota EstudianteById(int Id)
        {
            for(int i=0; i < datos.Count; i++)
            {
                if (Id == datos[i].Estudiante.Id)
                {
                    return datos[i];
                }
            }
            return null;
        }

        public ICollection<Asignatura> GetAsignaturas()
        {

           for(int i=0; i<datos.Count; i++)
            {
                return datos[i].Asignaturas;
            }
            return null;
        }

        public ICollection<Nota> MejoresEstudiantes()
        {
            List<Nota> MejoresNotas = new List<Nota>();
            datos.OrderBy(x => x.NotaFinal);
            for(int i=0; i<2; i++)
            {
                MejoresNotas.Add(datos[i]);
            }
            return MejoresNotas;
        }

    }
}
