using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Libros : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;
        
        public FM_Libros()
        {
            InitializeComponent();
        }

        public FM_Libros(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void FM_Libros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            modoBusqueda();

        }

        private void modoBusqueda()
        {
            gbEdicion.Enabled = false;
            gbBusqueda.Enabled = true;
        }

        private void modoEdicion()
        {
            gbEdicion.Enabled = true;
            gbBusqueda.Enabled = false;
            prestado_sn_libTextBox.Text = "N";
        }

        private void bBuscarID_Click(object sender, EventArgs e)
        {
            try
            {
                librosTableAdapter.FillByIDLibro(dS_Libros.libros, int.Parse(tbIDBusqueda.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato incorrecto, introduce un número");
            }
        }

        private void bBuscarTitulo_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByTitulo(dS_Libros.libros, tbTituloBusqueda.Text);
        }

        private void bBuscarAutor_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByAutor(dS_Libros.libros, tbAutorBusqueda.Text);
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            librosBindingSource.AddNew();
            modoEdicion();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            modoEdicion();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            int posicion = librosBindingSource.Position;
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Borrado", MessageBoxButtons.YesNo))
            {
                try
                {
                    librosBindingSource.RemoveCurrent();
                    librosTableAdapter.Update(dS_Libros.libros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el borrado " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se eliminó el registro");
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                librosBindingSource.EndEdit();
                librosTableAdapter.Update(dS_Libros.libros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el libro " + ex.Message);
            }
            modoBusqueda();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            modoEdicion();
        }

        private void bLookUp_Click(object sender, EventArgs e)
        {
            FM_Secciones fm = new FM_Secciones();
            fm.ShowDialog();
            seccion_libTextBox.Text = fm.IDSeccion.ToString();
        }
    }
}
