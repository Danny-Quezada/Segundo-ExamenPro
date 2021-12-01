using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
	public class NotaServices : BaseServices<Nota>,NotaRepositoryServices
	{
		// Aqui van todos los metodos de EstudianteRepositoryServices.
		private INotaRepository Repository;
		public NotaServices(INotaRepository repository) : base(repository)
		{
			this.Repository = repository;
		}

        public int CalcularPromedio()
        {
            return Repository.CalcularPromedio();
        }

        public Nota EstudianteById(int Id)
        {
            return Repository.EstudianteById(Id);
        }

        public ICollection<Asignatura> GetAsignaturas()
        {
            return Repository.GetAsignaturas();
        }

        public ICollection<Nota> MejoresEstudiantes()
        {
            return Repository.MejoresEstudiantes();
        }
    }
}
