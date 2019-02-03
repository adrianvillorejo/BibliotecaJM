using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Prestamos : BibliotecaJM.FM_Modelo
    {
        public string Prestado { get; set; }
        private UsuarioActual usuarioActual;

        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Configuracion.configuracion' Puede moverla o quitarla según sea necesario.
            this.configuracionTableAdapter.Fill(this.dS_Configuracion.configuracion);
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
        }

        private void bBuscarIDLector_Click(object sender, EventArgs e)
        {
            lectoresTableAdapter.FillByID(dS_Lectores.lectores, int.Parse(tbIDBusqueda.Text));
            librosPrestadosTableAdapter.FillByID(dS_LibrosPrestados.LibrosPrestados, int.Parse(tbIDBusqueda.Text));
        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            lectoresTableAdapter.FillByNombreExacto(dS_Lectores.lectores, tbNombreBusqueda.Text);
            librosPrestadosTableAdapter.FillByNombreExacto(dS_LibrosPrestados.LibrosPrestados, tbNombreBusqueda.Text);
        }

        private void bBuscarIDLibro_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByIDLibro(dS_Libros.libros, int.Parse(tbIDLibro.Text));
        }

        private void bBuscarTitulo_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByTitulo(dS_Libros.libros, tbTituloLibro.Text);
        }

        private void bBuscarAutor_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByAutor(dS_Libros.libros, tbAutorLibro.Text);
        }

        private void bPrestamo_Click(object sender, EventArgs e)
        {
            int posicion = librosBindingSource.Position;
            Prestado = dS_Libros.libros[posicion].prestado_sn_lib;
            int id = int.Parse(id_lecLabel1.Text);
            DateTime? fechaPena = dS_Lectores.lectores[id].fecha_penalizacion_lec;

            if (Prestado.Contains("N") && librosPrestadosDataGridView.RowCount <= 5)
            {
                if (fechaPena.Value==null && fechaPena<DateTime.Today)
                {
                    fechaPena = null;
                    Prestado = "S";
                    librosBindingSource.EndEdit();
                    librosTableAdapter.Update(dS_Libros.libros);
                    librosPrestadosBindingSource.AddNew();
                    int pos = librosPrestadosBindingSource.Position;
                    dS_LibrosPrestados.LibrosPrestados[pos].titulo_lib = dS_Libros.libros[posicion].titulo_lib;
                    dS_LibrosPrestados.LibrosPrestados[pos].fecha_presta_pre = DateTime.Today;
                    dS_LibrosPrestados.LibrosPrestados[pos].fecha_devol_pre = DateTime.Today.AddDays(dS_Configuracion.configuracion[0].dias_penalizacion_cnf);
                    librosPrestadosBindingSource.EndEdit();
                    librosPrestadosTableAdapter.Adapter.Update(dS_LibrosPrestados.LibrosPrestados);
                }
            }
            else
            {
                MessageBox.Show("No se puede prestar el libro porque ya está prestado o la persona tiene 5 libros prestados");
            }
            
        }
    }
}
