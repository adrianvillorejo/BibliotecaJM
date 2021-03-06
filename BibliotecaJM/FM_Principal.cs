﻿using System;
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
    public partial class FM_Principal : Form
    {
        UsuarioActual usuarioActual = new UsuarioActual();

        private void FM_Principal_Shown(object sender, EventArgs e)
        {
            FM_Login fm = new FM_Login();
            fm.ShowDialog();
            if (fm.usuarioActual == null)
            {
                this.Close();
            }
            this.usuarioActual = fm.usuarioActual;
        }

        public FM_Principal()
        {
            InitializeComponent();
        }
        public FM_Principal(string usuario, string tipo)
        {
            usuarioActual.Nombre = usuario;
            usuarioActual.TipoUsuario = tipo;
            InitializeComponent();
        }
        
        private void tsbLectores_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario.Equals("L"))
            {
                MessageBox.Show("No tienes perimisos, contacta con el administrador");
            }
            else
            {
                VisualizarFormularioYTítulo(new FM_Lectores(usuarioActual), "Mantenimiento lectores");
            }
        }

        private void tsbLibros_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario.Equals("L"))
            {
                MessageBox.Show("No tienes perimisos, contacta con el administrador");
            }
            else
            {
                VisualizarFormularioYTítulo(new FM_Libros(usuarioActual), "Mantenimiento libros");
            }
        }

        private void tsbPréstamos_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario.Equals("L"))
            {
                MessageBox.Show("No tienes perimisos, contacta con el administrador");
            }
            else
            {
                VisualizarFormularioYTítulo(new FM_Prestamos(usuarioActual), "Préstamos");
            }
        }

        private void tsbDevoluciones_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario.Equals("L"))
            {
                MessageBox.Show("No tienes perimisos, contacta con el administrador");
            }
            else
            {
                VisualizarFormularioYTítulo(new FM_Devoluciones(usuarioActual), "Devoluciones");
            }
        }

        private void tsbListados_Click(object sender, EventArgs e)
        {
            VisualizarFormularioYTítulo(new FM_Listados(usuarioActual), "Listados");
        }

        private void tsbGráficos_Click(object sender, EventArgs e)
        {
            VisualizarFormularioYTítulo(new FM_Graficos(usuarioActual), "Gráficos");
        }

        private void tsbConfiguración_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario.Equals("L") || usuarioActual.TipoUsuario.Equals("O"))
            {
                MessageBox.Show("No tienes perimisos, contacta con el administrador");
            }
            else
            {
                VisualizarFormularioYTítulo(new FM_Configuracion(usuarioActual), "Configuración");
            }
        }
        private void VisualizarFormularioYTítulo(Form formulario, string título)
        {
            if (MdiChildren.Count() == 1)
                MdiChildren[0].Close();
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
            this.Text = título;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripButton boton in toolStrip1.Items)
                boton.CheckState = CheckState.Unchecked;
        }

    }
}
