namespace BibliotecaJM
{
    partial class FM_Devoluciones
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
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.gbBusquedaDelLibro = new System.Windows.Forms.GroupBox();
            this.id_libLabel1 = new System.Windows.Forms.Label();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.titulo_libLabel1 = new System.Windows.Forms.Label();
            this.autor_libLabel1 = new System.Windows.Forms.Label();
            this.bBuscarLibro = new System.Windows.Forms.Button();
            this.tbBusquedaLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBusquedaDelLector = new System.Windows.Forms.GroupBox();
            this.id_lecLabel1 = new System.Windows.Forms.Label();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.nombre_lecLabel1 = new System.Windows.Forms.Label();
            this.domicilio_lecLabel1 = new System.Windows.Forms.Label();
            this.fecha_penalizacion_lecLabel1 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tbBusquedaLector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbLibrosPrestados = new System.Windows.Forms.GroupBox();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrestar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager1 = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.tableAdapterManager2 = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.TableAdapterManager();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.gbBusquedaDelLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            this.gbBusquedaDelLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.gbLibrosPrestados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            this.SuspendLayout();
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Location = new System.Drawing.Point(19, 130);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(43, 13);
            id_libLabel.TabIndex = 3;
            id_libLabel.Text = "ID libro:";
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Location = new System.Drawing.Point(19, 153);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(60, 13);
            titulo_libLabel.TabIndex = 5;
            titulo_libLabel.Text = "Título libro:";
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Location = new System.Drawing.Point(19, 176);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(57, 13);
            autor_libLabel.TabIndex = 7;
            autor_libLabel.Text = "Autor libro:";
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(31, 117);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(50, 13);
            id_lecLabel.TabIndex = 3;
            id_lecLabel.Text = "ID lector:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(31, 140);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(76, 13);
            nombre_lecLabel.TabIndex = 5;
            nombre_lecLabel.Text = "Nombre lector:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(31, 163);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(81, 13);
            domicilio_lecLabel.TabIndex = 7;
            domicilio_lecLabel.Text = "Domicilio lector:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(31, 186);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(117, 13);
            fecha_penalizacion_lecLabel.TabIndex = 15;
            fecha_penalizacion_lecLabel.Text = "Fecha de penalización:";
            // 
            // gbBusquedaDelLibro
            // 
            this.gbBusquedaDelLibro.Controls.Add(id_libLabel);
            this.gbBusquedaDelLibro.Controls.Add(this.id_libLabel1);
            this.gbBusquedaDelLibro.Controls.Add(titulo_libLabel);
            this.gbBusquedaDelLibro.Controls.Add(this.titulo_libLabel1);
            this.gbBusquedaDelLibro.Controls.Add(autor_libLabel);
            this.gbBusquedaDelLibro.Controls.Add(this.autor_libLabel1);
            this.gbBusquedaDelLibro.Controls.Add(this.bBuscarLibro);
            this.gbBusquedaDelLibro.Controls.Add(this.tbBusquedaLibro);
            this.gbBusquedaDelLibro.Controls.Add(this.label1);
            this.gbBusquedaDelLibro.Location = new System.Drawing.Point(13, 13);
            this.gbBusquedaDelLibro.Name = "gbBusquedaDelLibro";
            this.gbBusquedaDelLibro.Size = new System.Drawing.Size(497, 327);
            this.gbBusquedaDelLibro.TabIndex = 0;
            this.gbBusquedaDelLibro.TabStop = false;
            this.gbBusquedaDelLibro.Text = "Búsqueda del libro";
            // 
            // id_libLabel1
            // 
            this.id_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.id_libLabel1.Location = new System.Drawing.Point(103, 130);
            this.id_libLabel1.Name = "id_libLabel1";
            this.id_libLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_libLabel1.TabIndex = 4;
            this.id_libLabel1.Text = "label3";
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titulo_libLabel1
            // 
            this.titulo_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "titulo_lib", true));
            this.titulo_libLabel1.Location = new System.Drawing.Point(103, 153);
            this.titulo_libLabel1.Name = "titulo_libLabel1";
            this.titulo_libLabel1.Size = new System.Drawing.Size(100, 23);
            this.titulo_libLabel1.TabIndex = 6;
            this.titulo_libLabel1.Text = "label3";
            // 
            // autor_libLabel1
            // 
            this.autor_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor_lib", true));
            this.autor_libLabel1.Location = new System.Drawing.Point(103, 176);
            this.autor_libLabel1.Name = "autor_libLabel1";
            this.autor_libLabel1.Size = new System.Drawing.Size(100, 23);
            this.autor_libLabel1.TabIndex = 8;
            this.autor_libLabel1.Text = "label3";
            // 
            // bBuscarLibro
            // 
            this.bBuscarLibro.Location = new System.Drawing.Point(404, 25);
            this.bBuscarLibro.Name = "bBuscarLibro";
            this.bBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.bBuscarLibro.TabIndex = 2;
            this.bBuscarLibro.Text = "Buscar";
            this.bBuscarLibro.UseVisualStyleBackColor = true;
            this.bBuscarLibro.Click += new System.EventHandler(this.bBuscarLibro_Click);
            // 
            // tbBusquedaLibro
            // 
            this.tbBusquedaLibro.Location = new System.Drawing.Point(75, 27);
            this.tbBusquedaLibro.Name = "tbBusquedaLibro";
            this.tbBusquedaLibro.Size = new System.Drawing.Size(323, 20);
            this.tbBusquedaLibro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID libro:";
            // 
            // gbBusquedaDelLector
            // 
            this.gbBusquedaDelLector.Controls.Add(id_lecLabel);
            this.gbBusquedaDelLector.Controls.Add(this.id_lecLabel1);
            this.gbBusquedaDelLector.Controls.Add(nombre_lecLabel);
            this.gbBusquedaDelLector.Controls.Add(this.nombre_lecLabel1);
            this.gbBusquedaDelLector.Controls.Add(domicilio_lecLabel);
            this.gbBusquedaDelLector.Controls.Add(this.domicilio_lecLabel1);
            this.gbBusquedaDelLector.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbBusquedaDelLector.Controls.Add(this.fecha_penalizacion_lecLabel1);
            this.gbBusquedaDelLector.Controls.Add(this.bBuscar);
            this.gbBusquedaDelLector.Controls.Add(this.tbBusquedaLector);
            this.gbBusquedaDelLector.Controls.Add(this.label2);
            this.gbBusquedaDelLector.Location = new System.Drawing.Point(516, 13);
            this.gbBusquedaDelLector.Name = "gbBusquedaDelLector";
            this.gbBusquedaDelLector.Size = new System.Drawing.Size(485, 327);
            this.gbBusquedaDelLector.TabIndex = 0;
            this.gbBusquedaDelLector.TabStop = false;
            this.gbBusquedaDelLector.Text = "Búsqueda del lector";
            // 
            // id_lecLabel1
            // 
            this.id_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecLabel1.Location = new System.Drawing.Point(153, 117);
            this.id_lecLabel1.Name = "id_lecLabel1";
            this.id_lecLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_lecLabel1.TabIndex = 4;
            this.id_lecLabel1.Text = "label3";
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombre_lecLabel1
            // 
            this.nombre_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecLabel1.Location = new System.Drawing.Point(153, 140);
            this.nombre_lecLabel1.Name = "nombre_lecLabel1";
            this.nombre_lecLabel1.Size = new System.Drawing.Size(100, 23);
            this.nombre_lecLabel1.TabIndex = 6;
            this.nombre_lecLabel1.Text = "label3";
            // 
            // domicilio_lecLabel1
            // 
            this.domicilio_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecLabel1.Location = new System.Drawing.Point(153, 163);
            this.domicilio_lecLabel1.Name = "domicilio_lecLabel1";
            this.domicilio_lecLabel1.Size = new System.Drawing.Size(100, 23);
            this.domicilio_lecLabel1.TabIndex = 8;
            this.domicilio_lecLabel1.Text = "label3";
            // 
            // fecha_penalizacion_lecLabel1
            // 
            this.fecha_penalizacion_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecLabel1.Location = new System.Drawing.Point(153, 186);
            this.fecha_penalizacion_lecLabel1.Name = "fecha_penalizacion_lecLabel1";
            this.fecha_penalizacion_lecLabel1.Size = new System.Drawing.Size(100, 23);
            this.fecha_penalizacion_lecLabel1.TabIndex = 16;
            this.fecha_penalizacion_lecLabel1.Text = "label3";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(390, 25);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 2;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tbBusquedaLector
            // 
            this.tbBusquedaLector.Location = new System.Drawing.Point(87, 27);
            this.tbBusquedaLector.Name = "tbBusquedaLector";
            this.tbBusquedaLector.Size = new System.Drawing.Size(297, 20);
            this.tbBusquedaLector.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID lector:";
            // 
            // gbLibrosPrestados
            // 
            this.gbLibrosPrestados.Controls.Add(this.librosPrestadosDataGridView);
            this.gbLibrosPrestados.Location = new System.Drawing.Point(13, 346);
            this.gbLibrosPrestados.Name = "gbLibrosPrestados";
            this.gbLibrosPrestados.Size = new System.Drawing.Size(985, 342);
            this.gbLibrosPrestados.TabIndex = 0;
            this.gbLibrosPrestados.TabStop = false;
            this.gbLibrosPrestados.Text = "Libros prestados";
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AllowUserToAddRows = false;
            this.librosPrestadosDataGridView.AllowUserToDeleteRows = false;
            this.librosPrestadosDataGridView.AllowUserToResizeColumns = false;
            this.librosPrestadosDataGridView.AllowUserToResizeRows = false;
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.bPrestar});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(22, 30);
            this.librosPrestadosDataGridView.MultiSelect = false;
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.ReadOnly = true;
            this.librosPrestadosDataGridView.RowHeadersVisible = false;
            this.librosPrestadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(946, 293);
            this.librosPrestadosDataGridView.TabIndex = 0;
            this.librosPrestadosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.librosPrestadosDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha de prestamo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha de devolución";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bPrestar
            // 
            this.bPrestar.HeaderText = "";
            this.bPrestar.Name = "bPrestar";
            this.bPrestar.ReadOnly = true;
            this.bPrestar.Text = "Realizar préstamo";
            this.bPrestar.UseColumnTextForButtonValue = true;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.lectoresTableAdapter = this.lectoresTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = BibliotecaJM.DS_LibrosPrestadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FM_Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.gbBusquedaDelLector);
            this.Controls.Add(this.gbLibrosPrestados);
            this.Controls.Add(this.gbBusquedaDelLibro);
            this.Name = "FM_Devoluciones";
            this.Load += new System.EventHandler(this.FM_Devoluciones_Load);
            this.gbBusquedaDelLibro.ResumeLayout(false);
            this.gbBusquedaDelLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            this.gbBusquedaDelLector.ResumeLayout(false);
            this.gbBusquedaDelLector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.gbLibrosPrestados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBusquedaDelLibro;
        private System.Windows.Forms.GroupBox gbBusquedaDelLector;
        private System.Windows.Forms.GroupBox gbLibrosPrestados;
        private System.Windows.Forms.Button bBuscarLibro;
        private System.Windows.Forms.TextBox tbBusquedaLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tbBusquedaLector;
        private System.Windows.Forms.Label label2;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_libLabel1;
        private System.Windows.Forms.Label titulo_libLabel1;
        private System.Windows.Forms.Label autor_libLabel1;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label id_lecLabel1;
        private System.Windows.Forms.Label nombre_lecLabel1;
        private System.Windows.Forms.Label domicilio_lecLabel1;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel1;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private DS_LibrosPrestadosTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn bPrestar;
    }
}
