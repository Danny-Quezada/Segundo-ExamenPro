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
        public NotaRepositoryServices Services { get; set; }
       
        public FrmNotas(int Id)
        {
            
            InitializeComponent();
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
            var Estudiantes = Services.Read();
            
        }
    }
}
