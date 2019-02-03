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
            //InitializeComponent();
        }

        public FM_Libros(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
            modoBusqueda();
        }

        private void modoBusqueda()
        {
            gbBusqueda.Enabled = true;
            gbEdicion.Enabled = false;
        }

        private void modoEdicion()
        {
            gbBusqueda.Enabled = false;
            gbEdicion.Enabled = true;
            titulo_libTextBox.Focus();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Libros);

        }

        private void FM_Libros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);

        }

        private void bSeccion_Click(object sender, EventArgs e)
        {
            FM_Seccion fm = new FM_Seccion();
            fm.ShowDialog();
            seccion_libTextBox.Text = fm.seccion.ToString();
        }

        private void bBuscarID_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByIDLibro(dS_Libros.libros,int.Parse(tbIDBusqueda.Text));
        }

        private void bBuscarLibro_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByTitulo(dS_Libros.libros, tbLibro.Text);
        }

        private void bBuscarAutor_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByAutor(dS_Libros.libros, tbAutor.Text);
        }
    }
}
