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

        DS_Prestamos.prestamosDataTable prestamos = new DS_Prestamos.prestamosDataTable();
        DS_Configuracion.configuracionDataTable configuracion = new DS_Configuracion.configuracionDataTable();
        DS_ConfiguracionTableAdapters.configuracionTableAdapter tableAdapter = new DS_ConfiguracionTableAdapters.configuracionTableAdapter();
        DS_PrestamosTableAdapters.prestamosTableAdapter ta = new DS_PrestamosTableAdapters.prestamosTableAdapter();

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
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
        }

        private void bBuscarIDLector_Click(object sender, EventArgs e)
        {
            try
            {
                lectoresTableAdapter.FillByID(dS_Lectores.lectores, int.Parse(tbIDBusqueda.Text));
                librosPrestadosTableAdapter.FillByID(dS_LibrosPrestados.LibrosPrestados, int.Parse(tbIDBusqueda.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No has introducido bien los datos o está vacía la busqueda" + ex.ToString());
                tbIDBusqueda.Focus();
            }
        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            lectoresTableAdapter.FillByNombreExacto(dS_Lectores.lectores, tbNombreBusqueda.Text);
            librosPrestadosTableAdapter.FillByNombreExacto(dS_LibrosPrestados.LibrosPrestados, tbNombreBusqueda.Text);
        }

        private void bBuscarIDLibro_Click(object sender, EventArgs e)
        {
            try
            {
                librosTableAdapter.FillByIDLibro(dS_Libros.libros, int.Parse(tbIDLibro.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No has introducido bien los datos o está vacía la busqueda" + ex.ToString());
                tbIDLibro.Focus();
            }
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

            if (id_lecLabel1.Text != "")
            {
                if (Prestado.Contains("N") && librosPrestadosDataGridView.RowCount <= 5)
                {
                    if (dS_Lectores.lectores[0].Isfecha_penalizacion_lecNull() || dS_Lectores.lectores[0].fecha_penalizacion_lec < DateTime.Today)
                    {
                        tableAdapter.Fill(configuracion);
                        DS_Prestamos.prestamosRow fila = prestamos.NewprestamosRow();

                        fila.id_lec_pre = dS_Lectores.lectores[0].id_lec;
                        fila.id_lib_pre = dS_Libros.libros[posicion].id_lib;
                        fila.fecha_presta_pre = DateTime.Now;
                        fila.fecha_devol_pre = DateTime.Now.AddDays(configuracion[0].dias_prestamo_cnf);
                        prestamos.AddprestamosRow(fila);
                        ta.Update(prestamos);
                        MessageBox.Show("El préstamo se ha realizado correctamente");
                        librosPrestadosTableAdapter.FillByID(dS_LibrosPrestados.LibrosPrestados, int.Parse(tbIDBusqueda.Text));

                        dS_Libros.libros[posicion].prestado_sn_lib.Remove(0);
                        dS_Libros.libros[posicion].prestado_sn_lib = "S";
                        librosBindingSource.EndEdit();
                        librosTableAdapter.Update(dS_Libros.libros);
                        librosDataGridView.Update();

                        //string fechaPenalizacion = dS_Lectores.lectores[0].fecha_penalizacion_lec.ToString().Remove(0);
                        //lectoresBindingSource.EndEdit();
                        //lectoresTableAdapter.Update(dS_Lectores.lectores);
                    }
                    else
                    {
                        MessageBox.Show("El lector tiene penalización");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede prestar el libro porque ya está prestado o la persona tiene 5 libros prestados");
                }
            }
            else
            {
                MessageBox.Show("Antes debes de buscar un lector al que le quieras realizar un préstamo");
                tbIDBusqueda.Focus();
            }
        }
    }
}
