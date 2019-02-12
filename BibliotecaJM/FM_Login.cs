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
        DS_Usuarios.usuariosDataTable dsUsuarios = new DS_Usuarios.usuariosDataTable();
        DS_UsuariosTableAdapters.usuariosTableAdapter taUsuarios = new DS_UsuariosTableAdapters.usuariosTableAdapter();
        public UsuarioActual usuarioActual { get; set; }
        int contador = 0;

        public FM_Login()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {

            if (contador == 2)
            {
                this.Close();
            }

            var usuario = new DS_Usuarios.usuariosDataTable();
            var ta = new DS_UsuariosTableAdapters.usuariosTableAdapter();
            var n = ta.FillByLogin(usuario, tbUsuario.Text);
            

            if (n == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrectas");
                contador++;
            }
            else
            {
                if (tbContraseña.Text == usuario[0].password_usu.Trim())
                {
                    usuarioActual = new UsuarioActual();
                    usuarioActual.Nombre = tbUsuario.Text;
                    usuarioActual.TipoUsuario = usuario[0].tipo_usu;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectas. Te quedan {3-nIntentos} intentos");
                    contador++;
                }

            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
