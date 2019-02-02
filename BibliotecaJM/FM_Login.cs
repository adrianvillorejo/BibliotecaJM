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
    public partial class FM_Login : Form
    {

        UsuarioActual usuarioActual = new UsuarioActual();

        public FM_Login()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string tipo = "";
            string contraseña = tbContraseña.Text;

            if (!usuario.Equals("") && !contraseña.Equals(""))
            {
                if (usuariosTableAdapter.FillByLogin(dS_Usuarios.usuarios,usuario,contraseña)==1)
                {
                    int posicion = usuariosBindingSource.Position;
                    tipo = dS_Usuarios.usuarios[posicion].tipo_usu;
                    usuarioActual.Nombre = usuario;
                    FM_Principal principal = new FM_Principal(usuario, tipo);
                    principal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    tbUsuario.Text = "";
                    tbContraseña.Text = "";
                    tbUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Rellena todos los campos");
                tbUsuario.Text = "";
                tbContraseña.Text = "";
                tbUsuario.Focus();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
