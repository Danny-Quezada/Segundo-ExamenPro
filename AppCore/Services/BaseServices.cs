using AppCore.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
	public abstract class BaseServices<T> : IServices<T>
	{
		private IModel<T> Model;
		protected BaseServices(IModel<T> model)
		{
			this.Model= model;
		}
		public void Create(T t)
		{
			Model.Create(t);
		}

		public void Delele(T t)
		{
			Model.Delele(t);
		}

		public int GetLastId()
		{
			return Model.GetLastId();
		}

		public ICollection<T> Read()
		{
			return Model.Read();
		}
	}
}
