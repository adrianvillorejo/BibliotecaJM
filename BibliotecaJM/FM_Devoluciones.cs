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

        }

        private void bBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                librosPrestadosTableAdapter.FillByIDLibro(dS_LibrosPrestados.LibrosPrestados, int.Parse(tbBusquedaLibro.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduce bien los datos" + ex.ToString());
                tbBusquedaLibro.Focus();
            }

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                librosPrestadosTableAdapter.FillByID(dS_LibrosPrestados.LibrosPrestados, int.Parse(tbBusquedaLector.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduce bien los datos" + ex.ToString());
            }

        }

        private void librosPrestadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = librosBindingSource.Position;
            if (e.ColumnIndex == 4)
            {
                if (tbBusquedaLector.Text != "")
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
                    DS_Historico_prestamos.historico_prestamosRow fila = historicoPrestamos.Newhistorico_prestamosRow();

                    fila.id_lec_his = int.Parse(id_lecLabel1.Text);
                    fila.id_lib_his = dS_LibrosPrestados.LibrosPrestados[pos].id_lib;
                    fila.fecha_presta_his = dS_LibrosPrestados.LibrosPrestados[pos].fecha_presta_pre;
                    fila.fecha_devol_his = DateTime.Now;
                    historicoPrestamos.Addhistorico_prestamosRow(fila);
                    taHistorico.Update(historicoPrestamos);

                    if (dS_LibrosPrestados.LibrosPrestados[pos].fecha_devol_pre < DateTime.Now)
                    {
                        for (int i = 0; i < dS_Lectores.lectores.Count; i++)
                        {
                            if (dS_Lectores.lectores[i].id_lec == int.Parse(id_lecLabel1.Text))
                            {
                                int penalizacion = DateTime.Now.DayOfYear - dS_LibrosPrestados.LibrosPrestados[pos].fecha_devol_pre.DayOfYear;
                                if (configuracion[0].dias_penalizacion_cnf < penalizacion)
                                {
                                    dS_Lectores.lectores[i].fecha_penalizacion_lec = DateTime.Now.AddDays(configuracion[0].dias_penalizacion_cnf);
                                    lectoresBindingSource.EndEdit();
                                    lectoresTableAdapter.Update(dS_Lectores.lectores);
                                }
                                else
                                {
                                    dS_Lectores.lectores[i].fecha_penalizacion_lec = dS_LibrosPrestados.LibrosPrestados[pos].fecha_devol_pre.AddDays(penalizacion);
                                    lectoresBindingSource.EndEdit();
                                    lectoresTableAdapter.Update(dS_Lectores.lectores);
                                }
                            }

                        }
                    }else
                            fila.fecha_devol_his = DateTime.Now;
                    }
                    dS_Libros.libros[0].prestado_sn_lib.Remove(0, dS_Libros.libros[0].prestado_sn_lib.Length);
                    dS_Libros.libros[0].prestado_sn_lib = "N";
                    librosBindingSource.EndEdit();
                    librosTableAdapter.Update(dS_Libros.libros);
            }
                else
                {
                    MessageBox.Show("Antes de devolver el libro, debes de buscar el lector que tiene ese libro");
                }
            }
        }
    }
}
