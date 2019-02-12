namespace BibliotecaJM
{
    partial class FM_Libros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_libLabel;
            System.Windows.Forms.Label titulo_libLabel;
            System.Windows.Forms.Label autor_libLabel;
            System.Windows.Forms.Label seccion_libLabel;
            System.Windows.Forms.Label prestado_sn_libLabel;
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.bBuscarAutor = new System.Windows.Forms.Button();
            this.bBuscarTitulo = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bBuscarID = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAutorBusqueda = new System.Windows.Forms.TextBox();
            this.tbTituloBusqueda = new System.Windows.Forms.TextBox();
            this.tbIDBusqueda = new System.Windows.Forms.TextBox();
            this.gbEdicion = new System.Windows.Forms.GroupBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.id_libTextBox = new System.Windows.Forms.TextBox();
            this.titulo_libTextBox = new System.Windows.Forms.TextBox();
            this.autor_libTextBox = new System.Windows.Forms.TextBox();
            this.seccion_libTextBox = new System.Windows.Forms.TextBox();
            this.prestado_sn_libTextBox = new System.Windows.Forms.TextBox();
            this.bLookUp = new System.Windows.Forms.Button();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            seccion_libLabel = new System.Windows.Forms.Label();
            prestado_sn_libLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.gbEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Location = new System.Drawing.Point(138, 109);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(21, 13);
            id_libLabel.TabIndex = 0;
            id_libLabel.Text = "ID:";
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Location = new System.Drawing.Point(138, 135);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(36, 13);
            titulo_libLabel.TabIndex = 2;
            titulo_libLabel.Text = "Titulo:";
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Location = new System.Drawing.Point(138, 161);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(32, 13);
            autor_libLabel.TabIndex = 4;
            autor_libLabel.Text = "Autor";
            // 
            // seccion_libLabel
            // 
            seccion_libLabel.AutoSize = true;
            seccion_libLabel.Location = new System.Drawing.Point(138, 187);
            seccion_libLabel.Name = "seccion_libLabel";
            seccion_libLabel.Size = new System.Drawing.Size(46, 13);
            seccion_libLabel.TabIndex = 6;
            seccion_libLabel.Text = "Seccion";
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.librosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(21, 117);
            this.librosDataGridView.MultiSelect = false;
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.RowHeadersVisible = false;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(440, 428);
            this.librosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prestado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.bBuscarAutor);
            this.gbBusqueda.Controls.Add(this.bBuscarTitulo);
            this.gbBusqueda.Controls.Add(this.bEliminar);
            this.gbBusqueda.Controls.Add(this.bModificar);
            this.gbBusqueda.Controls.Add(this.bNuevo);
            this.gbBusqueda.Controls.Add(this.bBuscarID);
            this.gbBusqueda.Controls.Add(this.label3);
            this.gbBusqueda.Controls.Add(this.label2);
            this.gbBusqueda.Controls.Add(this.label1);
            this.gbBusqueda.Controls.Add(this.tbAutorBusqueda);
            this.gbBusqueda.Controls.Add(this.tbTituloBusqueda);
            this.gbBusqueda.Controls.Add(this.tbIDBusqueda);
            this.gbBusqueda.Controls.Add(this.librosDataGridView);
            this.gbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(484, 600);
            this.gbBusqueda.TabIndex = 2;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // bBuscarAutor
            // 
            this.bBuscarAutor.Location = new System.Drawing.Point(394, 79);
            this.bBuscarAutor.Name = "bBuscarAutor";
            this.bBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.bBuscarAutor.TabIndex = 4;
            this.bBuscarAutor.Text = "Buscar";
            this.bBuscarAutor.UseVisualStyleBackColor = true;
            this.bBuscarAutor.Click += new System.EventHandler(this.bBuscarAutor_Click);
            // 
            // bBuscarTitulo
            // 
            this.bBuscarTitulo.Location = new System.Drawing.Point(394, 53);
            this.bBuscarTitulo.Name = "bBuscarTitulo";
            this.bBuscarTitulo.Size = new System.Drawing.Size(75, 23);
            this.bBuscarTitulo.TabIndex = 4;
            this.bBuscarTitulo.Text = "Buscar";
            this.bBuscarTitulo.UseVisualStyleBackColor = true;
            this.bBuscarTitulo.Click += new System.EventHandler(this.bBuscarTitulo_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(386, 560);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(202, 560);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 4;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(21, 560);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 4;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bBuscarID
            // 
            this.bBuscarID.Location = new System.Drawing.Point(394, 27);
            this.bBuscarID.Name = "bBuscarID";
            this.bBuscarID.Size = new System.Drawing.Size(75, 23);
            this.bBuscarID.TabIndex = 4;
            this.bBuscarID.Text = "Buscar";
            this.bBuscarID.UseVisualStyleBackColor = true;
            this.bBuscarID.Click += new System.EventHandler(this.bBuscarID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // tbAutorBusqueda
            // 
            this.tbAutorBusqueda.Location = new System.Drawing.Point(66, 81);
            this.tbAutorBusqueda.Name = "tbAutorBusqueda";
            this.tbAutorBusqueda.Size = new System.Drawing.Size(322, 20);
            this.tbAutorBusqueda.TabIndex = 2;
            // 
            // tbTituloBusqueda
            // 
            this.tbTituloBusqueda.Location = new System.Drawing.Point(66, 55);
            this.tbTituloBusqueda.Name = "tbTituloBusqueda";
            this.tbTituloBusqueda.Size = new System.Drawing.Size(322, 20);
            this.tbTituloBusqueda.TabIndex = 2;
            // 
            // tbIDBusqueda
            // 
            this.tbIDBusqueda.Location = new System.Drawing.Point(66, 29);
            this.tbIDBusqueda.Name = "tbIDBusqueda";
            this.tbIDBusqueda.Size = new System.Drawing.Size(322, 20);
            this.tbIDBusqueda.TabIndex = 2;
            // 
            // gbEdicion
            // 
            this.gbEdicion.Controls.Add(this.bLookUp);
            this.gbEdicion.Controls.Add(this.bCancelar);
            this.gbEdicion.Controls.Add(this.bAceptar);
            this.gbEdicion.Controls.Add(id_libLabel);
            this.gbEdicion.Controls.Add(this.id_libTextBox);
            this.gbEdicion.Controls.Add(titulo_libLabel);
            this.gbEdicion.Controls.Add(this.titulo_libTextBox);
            this.gbEdicion.Controls.Add(autor_libLabel);
            this.gbEdicion.Controls.Add(this.autor_libTextBox);
            this.gbEdicion.Controls.Add(seccion_libLabel);
            this.gbEdicion.Controls.Add(this.seccion_libTextBox);
            this.gbEdicion.Controls.Add(prestado_sn_libLabel);
            this.gbEdicion.Controls.Add(this.prestado_sn_libTextBox);
            this.gbEdicion.Location = new System.Drawing.Point(502, 12);
            this.gbEdicion.Name = "gbEdicion";
            this.gbEdicion.Size = new System.Drawing.Size(496, 600);
            this.gbEdicion.TabIndex = 2;
            this.gbEdicion.TabStop = false;
            this.gbEdicion.Text = "Edicion";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(285, 301);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 10;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(132, 301);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 10;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // id_libTextBox
            // 
            this.id_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.id_libTextBox.Location = new System.Drawing.Point(222, 106);
            this.id_libTextBox.Name = "id_libTextBox";
            this.id_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_libTextBox.TabIndex = 1;
            // 
            // titulo_libTextBox
            // 
            this.titulo_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "titulo_lib", true));
            this.titulo_libTextBox.Location = new System.Drawing.Point(222, 132);
            this.titulo_libTextBox.Name = "titulo_libTextBox";
            this.titulo_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.titulo_libTextBox.TabIndex = 3;
            // 
            // autor_libTextBox
            // 
            this.autor_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor_lib", true));
            this.autor_libTextBox.Location = new System.Drawing.Point(222, 158);
            this.autor_libTextBox.Name = "autor_libTextBox";
            this.autor_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.autor_libTextBox.TabIndex = 5;
            // 
            // seccion_libTextBox
            // 
            this.seccion_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "seccion_lib", true));
            this.seccion_libTextBox.Location = new System.Drawing.Point(222, 184);
            this.seccion_libTextBox.Name = "seccion_libTextBox";
            this.seccion_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.seccion_libTextBox.TabIndex = 7;
            // 
            // prestado_sn_libTextBox
            // 
            this.prestado_sn_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "prestado_sn_lib", true));
            this.prestado_sn_libTextBox.Enabled = false;
            this.prestado_sn_libTextBox.Location = new System.Drawing.Point(222, 210);
            this.prestado_sn_libTextBox.Name = "prestado_sn_libTextBox";
            this.prestado_sn_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.prestado_sn_libTextBox.TabIndex = 9;
            // 
            // prestado_sn_libLabel
            // 
            prestado_sn_libLabel.AutoSize = true;
            prestado_sn_libLabel.Location = new System.Drawing.Point(138, 213);
            prestado_sn_libLabel.Name = "prestado_sn_libLabel";
            prestado_sn_libLabel.Size = new System.Drawing.Size(52, 13);
            prestado_sn_libLabel.TabIndex = 8;
            prestado_sn_libLabel.Text = "Prestado:";
            // 
            // bLookUp
            // 
            this.bLookUp.Location = new System.Drawing.Point(337, 182);
            this.bLookUp.Name = "bLookUp";
            this.bLookUp.Size = new System.Drawing.Size(32, 23);
            this.bLookUp.TabIndex = 11;
            this.bLookUp.Text = "...";
            this.bLookUp.UseVisualStyleBackColor = true;
            this.bLookUp.Click += new System.EventHandler(this.bLookUp_Click);
            // 
            // FM_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.gbEdicion);
            this.Controls.Add(this.gbBusqueda);
            this.Name = "FM_Libros";
            this.Load += new System.EventHandler(this.FM_Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbEdicion.ResumeLayout(false);
            this.gbEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button bBuscarAutor;
        private System.Windows.Forms.Button bBuscarTitulo;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bBuscarID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAutorBusqueda;
        private System.Windows.Forms.TextBox tbTituloBusqueda;
        private System.Windows.Forms.TextBox tbIDBusqueda;
        private System.Windows.Forms.GroupBox gbEdicion;
        private System.Windows.Forms.TextBox id_libTextBox;
        private System.Windows.Forms.TextBox titulo_libTextBox;
        private System.Windows.Forms.TextBox autor_libTextBox;
        private System.Windows.Forms.TextBox seccion_libTextBox;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox prestado_sn_libTextBox;
        private System.Windows.Forms.Button bLookUp;
    }
}
