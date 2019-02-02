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
    public partial class FMProvincia : Form
    {
        public string provincia { get; set; }

        public FMProvincia()
        {
            InitializeComponent();
        }

        private void provinciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.provinciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Provincias);

        }

        private void FMProvincia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Provincias.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.dS_Provincias.provincias);

        }

        private void provinciasDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int posicion = provinciasBindingSource.Position;
            provincia = dS_Provincias.provincias[posicion].id_pro.ToString();
            this.Close();
        }
    }
}
