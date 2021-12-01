﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface INotaRepository: IModel<Nota>
	{
        // Aqui poner los metodos que se ocuparan para la clase Estudiante.
        int CalcularPromedio();
        ICollection<Estudiante> MejoresEstudiantes();
        ICollection<Nota> GetAsignaturas();

	}
}