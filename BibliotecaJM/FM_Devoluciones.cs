using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Devoluciones : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Devoluciones()
        {
            InitializeComponent();
        }

        public FM_Devoluciones(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void FM_Devoluciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_LibrosPrestados.LibrosPrestados' Puede moverla o quitarla según sea necesario.
            this.librosPrestadosTableAdapter.Fill(this.dS_LibrosPrestados.LibrosPrestados);
        }

        private void bBuscarLibro_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByIDLibro(dS_Libros.libros, int.Parse(tbBusquedaLibro.Text));
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            lectoresTableAdapter.FillByID(dS_Lectores.lectores, int.Parse(tbBusquedaLector.Text));
        }

        private void librosPrestadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = librosBindingSource.Position;
            if (e.ColumnIndex==4)
            {
                DS_Prestamos.prestamosDataTable prestamos = new DS_Prestamos.prestamosDataTable();
                DS_PrestamosTableAdapters.prestamosTableAdapter taPrestamos = new DS_PrestamosTableAdapters.prestamosTableAdapter();
                BindingSource binding = new BindingSource();
                taPrestamos.Fill(prestamos);
                DS_Configuracion.configuracionDataTable configuracion = new DS_Configuracion.configuracionDataTable();
                DS_ConfiguracionTableAdapters.configuracionTableAdapter taConfiguracion = new DS_ConfiguracionTableAdapters.configuracionTableAdapter();
                taConfiguracion.Fill(configuracion);
                DS_Historico_prestamos.historico_prestamosDataTable historicoPrestamos = new DS_Historico_prestamos.historico_prestamosDataTable();
                DS_Historico_prestamosTableAdapters.historico_prestamosTableAdapter taHistorico = new DS_Historico_prestamosTableAdapters.historico_prestamosTableAdapter();
                

            }
        }
    }
}
