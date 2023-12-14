using Entidades;

namespace View
{
    public partial class FrmView : Form
    {
        private Biblioteca biblioteca;
        private Libro libroSeleccionado;
        public FrmView()
        {
            InitializeComponent();
            biblioteca = new Biblioteca("Mi biblioteca");
            ActualizarLista();

        }

        private void btnIngresarLibro_Click(object sender, EventArgs e)
        {
            FrmAltaLibro frmAltaLibro = new FrmAltaLibro();

            frmAltaLibro.ShowDialog();

            biblioteca += frmAltaLibro.libroCreado;

            ActualizarLista();

        }

        private void btnDarBajaLibro_Click(object sender, EventArgs e)
        {
            if (lstLibros.SelectedIndex == -1)
            {
                libroSeleccionado = (Libro)lstLibros.SelectedItem;
                biblioteca -= libroSeleccionado;
            }
            ActualizarLista();
        }

        private void btnListarBiblioteca_Click(object sender, EventArgs e)
        {
            rchDetalleBiblioteca.Text = Biblioteca.DetallarBiblioteca(biblioteca);
        }

        private void ActualizarLista()
        {
            lstLibros.Items.Clear();
            foreach(var libro in biblioteca.Libros)
            {
                lstLibros.Items.Add(libro);
            }
        }
    }
}