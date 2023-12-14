using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmAltaLibro : Form
    {
        private Libro libro;
        private ETipoDeLibro tipoSeleccionado;

        public Libro libroCreado
        {
            get { return libro; }
        }
        public FrmAltaLibro()
        {
            InitializeComponent();
        }

        private void FrmAltaLibro_Load(object sender, EventArgs e)
        {
            cmbDificultad.Items.Add(ENivelDificultad.Baja.ToString());
            cmbDificultad.Items.Add(ENivelDificultad.Media.ToString());
            cmbDificultad.Items.Add(ENivelDificultad.Alta.ToString());

            cmbTipoLibro.Items.Add(ETipoDeLibro.Ciencia_Ficcion.ToString());
            cmbTipoLibro.Items.Add(ETipoDeLibro.Historietas.ToString());
            cmbTipoLibro.Items.Add(ETipoDeLibro.Misterio.ToString());
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            bool esEdicionEspecial = chbEdicionEspecial.Checked;
            bool tieneColor = chbAColor.Checked;
            ENivelDificultad dificultad = (ENivelDificultad)cmbDificultad.SelectedItem;

            if(tipoSeleccionado == ETipoDeLibro.Misterio)
            {
                libro = new LibroDeMisterio(nombre, esEdicionEspecial);
            }
            if(tipoSeleccionado == ETipoDeLibro.Historietas)
            {
                libro = new LibroDeHistorietas(nombre,tieneColor);
            }
            if(tipoSeleccionado == ETipoDeLibro.Ciencia_Ficcion)
            {
                libro = new LibroCienciaFiccion(nombre, dificultad);
            }

             

            this.Close();

        }

        private void cmbTipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoSeleccionado = (ETipoDeLibro)cmbTipoLibro.SelectedItem;
            
        }
    }
}
