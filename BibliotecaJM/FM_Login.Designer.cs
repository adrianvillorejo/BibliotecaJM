namespace BibliotecaJM
{
    partial class FM_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label nombre_usuLabel;
            System.Windows.Forms.Label password_usuLabel;
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            nombre_usuLabel = new System.Windows.Forms.Label();
            password_usuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombre_usuLabel
            // 
            nombre_usuLabel.AutoSize = true;
            nombre_usuLabel.Location = new System.Drawing.Point(89, 91);
            nombre_usuLabel.Name = "nombre_usuLabel";
            nombre_usuLabel.Size = new System.Drawing.Size(46, 13);
            nombre_usuLabel.TabIndex = 5;
            nombre_usuLabel.Text = "Usuario:";
            // 
            // password_usuLabel
            // 
            password_usuLabel.AutoSize = true;
            password_usuLabel.Location = new System.Drawing.Point(89, 143);
            password_usuLabel.Name = "password_usuLabel";
            password_usuLabel.Size = new System.Drawing.Size(64, 13);
            password_usuLabel.TabIndex = 7;
            password_usuLabel.Text = "Contraseña:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(99, 218);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 2;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(351, 218);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(172, 88);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(254, 20);
            this.tbUsuario.TabIndex = 6;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(172, 140);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(254, 20);
            this.tbContraseña.TabIndex = 8;
            // 
            // FM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 288);
            this.Controls.Add(nombre_usuLabel);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(password_usuLabel);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Name = "FM_Login";
            this.Text = "FM_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
    }
}