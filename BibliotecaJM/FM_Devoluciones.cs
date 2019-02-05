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
            // TODO: esta línea de código carga datos en la tabla 'dS_Configuracion.configuracion' Puede moverla o quitarla según sea necesario.
            this.configuracionTableAdapter.Fill(this.dS_Configuracion.configuracion);
            // TODO: esta línea de código carga datos en la tabla 'dS_Configuracion.configuracion' Puede moverla o quitarla según sea necesario.
            this.configuracionTableAdapter.Fill(this.dS_Configuracion.configuracion);
            // TODO: esta línea de código carga datos en la tabla 'dS_Historico_prestamos.historico_prestamos' Puede moverla o quitarla según sea necesario.
            this.historico_prestamosTableAdapter.Fill(this.dS_Historico_prestamos.historico_prestamos);
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
                historico_prestamosBindingSource.AddNew();
                dS_Historico_prestamos.historico_prestamos[0].fecha_devol_his = DateTime.Today;
                if (dS_LibrosPrestados.LibrosPrestados[pos].fecha_devol_pre>DateTime.Today)
                {
                    int diasPenalizacion = DateTime.Today.DayOfYear - dS_LibrosPrestados.LibrosPrestados[pos].fecha_devol_pre.DayOfYear;
                    if (diasPenalizacion<dS_Configuracion.configuracion[0].dias_penalizacion_cnf)
                    {
                        dS_Lectores.lectores[].
                        dS_Historico_prestamos.historico_prestamos[0].
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("La fecha de devolución es superior al dia de hoy, por lo tanto serás penalizado");
                }
            }
        }
    }
}
