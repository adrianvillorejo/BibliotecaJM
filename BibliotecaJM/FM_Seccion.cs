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
    }
}
