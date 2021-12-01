using AppCore.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class FrmNotas : Form
    {
        int cambio = 0;
        public NotaRepositoryServices Services { get; set; }
        int Id = 0;
       
        public FrmNotas(int id)
        {
            this.Id = id;
            InitializeComponent();
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
            Estudiante estudiante=Services.EstudianteById(Id);
            lblNombre.Text = estudiante.Nombres + " "+estudiante.Apellidos;
            
        }

        private void LblAsignatura_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
