using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
	public interface NotaRepositoryServices: IServices<Nota>
	{
        // Aqui van todos los metodos de IEstudianteRepository
         Nota EstudianteById(int Id);
        int CalcularPromedio();
        ICollection<Nota> MejoresEstudiantes();
        ICollection<Asignatura> GetAsignaturas();

    }
}
