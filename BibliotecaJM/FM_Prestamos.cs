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
        private UsuarioActual usuarioActual;

        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
        }

        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            // TODO: esta línea de código carga datos en la tabla 'dS_LibrosPrestados.LibrosPrestados' Puede moverla o quitarla según sea necesario.
            this.librosPrestadosTableAdapter.Fill(this.dS_LibrosPrestados.LibrosPrestados);
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);

        }

        private void bBuscarIDLector_Click(object sender, EventArgs e)
        {
            lectoresTableAdapter.FillByID(dS_Lectores.lectores, int.Parse(tbIDBusqueda.Text));
        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            lectoresTableAdapter.FillByNombre(dS_Lectores.lectores, tbNombreBusqueda.Text);
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
    }
}
