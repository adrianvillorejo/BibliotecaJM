using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Seccion : Form
    {
        public int seccion { get; set; }

        public FM_Seccion()
        {
            InitializeComponent();
        }

        private void seccionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seccionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Secciones);

        }

        private void FM_Seccion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Secciones.secciones' Puede moverla o quitarla según sea necesario.
            this.seccionesTableAdapter.Fill(this.dS_Secciones.secciones);

        }

        private void seccionesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int posicion = seccionesBindingSource.Position;
            seccion = dS_Secciones.secciones[posicion].id_sec;
            this.Close();
            
        }
    }
}
