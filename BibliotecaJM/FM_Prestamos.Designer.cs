namespace BibliotecaJM
{
    partial class FM_Prestamos
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
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.gbBusquedaLector = new System.Windows.Forms.GroupBox();
            this.id_lecLabel1 = new System.Windows.Forms.Label();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.nombre_lecLabel1 = new System.Windows.Forms.Label();
            this.domicilio_lecLabel1 = new System.Windows.Forms.Label();
            this.fecha_penalizacion_lecLabel1 = new System.Windows.Forms.Label();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.bBuscarIDLector = new System.Windows.Forms.Button();
            this.tbNombreBusqueda = new System.Windows.Forms.TextBox();
            this.tbIDBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBusquedaLibro = new System.Windows.Forms.GroupBox();
            this.bPrestamo = new System.Windows.Forms.Button();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.bBuscarAutor = new System.Windows.Forms.Button();
            this.bBuscarTitulo = new System.Windows.Forms.Button();
            this.bBuscarIDLibro = new System.Windows.Forms.Button();
            this.tbAutorLibro = new System.Windows.Forms.TextBox();
            this.tbTituloLibro = new System.Windows.Forms.TextBox();
            this.tbIDLibro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.dS_Configuracion = new BibliotecaJM.DS_Configuracion();
            this.configuracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configuracionTableAdapter = new BibliotecaJM.DS_ConfiguracionTableAdapters.configuracionTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_ConfiguracionTableAdapters.TableAdapterManager();
            this.dS_Prestamos = new BibliotecaJM.DS_Prestamos();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new BibliotecaJM.DS_PrestamosTableAdapters.prestamosTableAdapter();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.gbBusquedaLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.gbBusquedaLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(15, 133);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(50, 13);
            id_lecLabel.TabIndex = 6;
            id_lecLabel.Text = "ID lector:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(15, 156);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(76, 13);
            nombre_lecLabel.TabIndex = 8;
            nombre_lecLabel.Text = "Nombre lector:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(15, 179);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(78, 13);
            domicilio_lecLabel.TabIndex = 10;
            domicilio_lecLabel.Text = "Domicilio lector";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(15, 204);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(99, 13);
            fecha_penalizacion_lecLabel.TabIndex = 18;
            fecha_penalizacion_lecLabel.Text = "Fecha penalizacion";
            // 
            // gbBusquedaLector
            // 
            this.gbBusquedaLector.Controls.Add(id_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.id_lecLabel1);
            this.gbBusquedaLector.Controls.Add(nombre_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.nombre_lecLabel1);
            this.gbBusquedaLector.Controls.Add(domicilio_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.domicilio_lecLabel1);
            this.gbBusquedaLector.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.fecha_penalizacion_lecLabel1);
            this.gbBusquedaLector.Controls.Add(this.bBuscarNombre);
            this.gbBusquedaLector.Controls.Add(this.bBuscarIDLector);
            this.gbBusquedaLector.Controls.Add(this.tbNombreBusqueda);
            this.gbBusquedaLector.Controls.Add(this.tbIDBusqueda);
            this.gbBusquedaLector.Controls.Add(this.label2);
            this.gbBusquedaLector.Controls.Add(this.label1);
            this.gbBusquedaLector.Location = new System.Drawing.Point(13, 13);
            this.gbBusquedaLector.Name = "gbBusquedaLector";
            this.gbBusquedaLector.Size = new System.Drawing.Size(498, 243);
            this.gbBusquedaLector.TabIndex = 0;
            this.gbBusquedaLector.TabStop = false;
            this.gbBusquedaLector.Text = "Busqueda lector";
            // 
            // id_lecLabel1
            // 
            this.id_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecLabel1.Location = new System.Drawing.Point(137, 133);
            this.id_lecLabel1.Name = "id_lecLabel1";
            this.id_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_lecLabel1.TabIndex = 7;
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
            this.nombre_lecLabel1.Location = new System.Drawing.Point(137, 156);
            this.nombre_lecLabel1.Name = "nombre_lecLabel1";
            this.nombre_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.nombre_lecLabel1.TabIndex = 9;
            this.nombre_lecLabel1.Text = "label3";
            // 
            // domicilio_lecLabel1
            // 
            this.domicilio_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecLabel1.Location = new System.Drawing.Point(137, 179);
            this.domicilio_lecLabel1.Name = "domicilio_lecLabel1";
            this.domicilio_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.domicilio_lecLabel1.TabIndex = 11;
            this.domicilio_lecLabel1.Text = "label3";
            // 
            // fecha_penalizacion_lecLabel1
            // 
            this.fecha_penalizacion_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecLabel1.Location = new System.Drawing.Point(137, 204);
            this.fecha_penalizacion_lecLabel1.Name = "fecha_penalizacion_lecLabel1";
            this.fecha_penalizacion_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.fecha_penalizacion_lecLabel1.TabIndex = 19;
            this.fecha_penalizacion_lecLabel1.Text = "label3";
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Location = new System.Drawing.Point(366, 58);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombre.TabIndex = 2;
            this.bBuscarNombre.Text = "Buscar";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bBuscarIDLector
            // 
            this.bBuscarIDLector.Location = new System.Drawing.Point(366, 24);
            this.bBuscarIDLector.Name = "bBuscarIDLector";
            this.bBuscarIDLector.Size = new System.Drawing.Size(75, 23);
            this.bBuscarIDLector.TabIndex = 2;
            this.bBuscarIDLector.Text = "Buscar";
            this.bBuscarIDLector.UseVisualStyleBackColor = true;
            this.bBuscarIDLector.Click += new System.EventHandler(this.bBuscarIDLector_Click);
            // 
            // tbNombreBusqueda
            // 
            this.tbNombreBusqueda.Location = new System.Drawing.Point(74, 60);
            this.tbNombreBusqueda.Name = "tbNombreBusqueda";
            this.tbNombreBusqueda.Size = new System.Drawing.Size(263, 20);
            this.tbNombreBusqueda.TabIndex = 1;
            // 
            // tbIDBusqueda
            // 
            this.tbIDBusqueda.Location = new System.Drawing.Point(74, 26);
            this.tbIDBusqueda.Name = "tbIDBusqueda";
            this.tbIDBusqueda.Size = new System.Drawing.Size(263, 20);
            this.tbIDBusqueda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID lector:";
            // 
            // gbBusquedaLibro
            // 
            this.gbBusquedaLibro.Controls.Add(this.bPrestamo);
            this.gbBusquedaLibro.Controls.Add(this.librosDataGridView);
            this.gbBusquedaLibro.Controls.Add(this.bBuscarAutor);
            this.gbBusquedaLibro.Controls.Add(this.bBuscarTitulo);
            this.gbBusquedaLibro.Controls.Add(this.bBuscarIDLibro);
            this.gbBusquedaLibro.Controls.Add(this.tbAutorLibro);
            this.gbBusquedaLibro.Controls.Add(this.tbTituloLibro);
            this.gbBusquedaLibro.Controls.Add(this.tbIDLibro);
            this.gbBusquedaLibro.Controls.Add(this.label5);
            this.gbBusquedaLibro.Controls.Add(this.label4);
            this.gbBusquedaLibro.Controls.Add(this.label3);
            this.gbBusquedaLibro.Location = new System.Drawing.Point(517, 12);
            this.gbBusquedaLibro.Name = "gbBusquedaLibro";
            this.gbBusquedaLibro.Size = new System.Drawing.Size(481, 649);
            this.gbBusquedaLibro.TabIndex = 0;
            this.gbBusquedaLibro.TabStop = false;
            this.gbBusquedaLibro.Text = "Buscar libro";
            // 
            // bPrestamo
            // 
            this.bPrestamo.Location = new System.Drawing.Point(36, 517);
            this.bPrestamo.Name = "bPrestamo";
            this.bPrestamo.Size = new System.Drawing.Size(406, 23);
            this.bPrestamo.TabIndex = 10;
            this.bPrestamo.Text = "REALIZAR PRÉSTAMO";
            this.bPrestamo.UseVisualStyleBackColor = true;
            this.bPrestamo.Click += new System.EventHandler(this.bPrestamo_Click);
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(36, 168);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.RowHeadersVisible = false;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(406, 297);
            this.librosDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn6.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn7.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn9.HeaderText = "Prestado";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
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
            // bBuscarAutor
            // 
            this.bBuscarAutor.Location = new System.Drawing.Point(385, 90);
            this.bBuscarAutor.Name = "bBuscarAutor";
            this.bBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.bBuscarAutor.TabIndex = 2;
            this.bBuscarAutor.Text = "Buscar";
            this.bBuscarAutor.UseVisualStyleBackColor = true;
            this.bBuscarAutor.Click += new System.EventHandler(this.bBuscarAutor_Click);
            // 
            // bBuscarTitulo
            // 
            this.bBuscarTitulo.Location = new System.Drawing.Point(385, 59);
            this.bBuscarTitulo.Name = "bBuscarTitulo";
            this.bBuscarTitulo.Size = new System.Drawing.Size(75, 23);
            this.bBuscarTitulo.TabIndex = 2;
            this.bBuscarTitulo.Text = "Buscar";
            this.bBuscarTitulo.UseVisualStyleBackColor = true;
            this.bBuscarTitulo.Click += new System.EventHandler(this.bBuscarTitulo_Click);
            // 
            // bBuscarIDLibro
            // 
            this.bBuscarIDLibro.Location = new System.Drawing.Point(385, 29);
            this.bBuscarIDLibro.Name = "bBuscarIDLibro";
            this.bBuscarIDLibro.Size = new System.Drawing.Size(75, 23);
            this.bBuscarIDLibro.TabIndex = 2;
            this.bBuscarIDLibro.Text = "Buscar";
            this.bBuscarIDLibro.UseVisualStyleBackColor = true;
            this.bBuscarIDLibro.Click += new System.EventHandler(this.bBuscarIDLibro_Click);
            // 
            // tbAutorLibro
            // 
            this.tbAutorLibro.Location = new System.Drawing.Point(81, 92);
            this.tbAutorLibro.Name = "tbAutorLibro";
            this.tbAutorLibro.Size = new System.Drawing.Size(278, 20);
            this.tbAutorLibro.TabIndex = 1;
            // 
            // tbTituloLibro
            // 
            this.tbTituloLibro.Location = new System.Drawing.Point(81, 61);
            this.tbTituloLibro.Name = "tbTituloLibro";
            this.tbTituloLibro.Size = new System.Drawing.Size(278, 20);
            this.tbTituloLibro.TabIndex = 1;
            // 
            // tbIDLibro
            // 
            this.tbIDLibro.Location = new System.Drawing.Point(81, 31);
            this.tbIDLibro.Name = "tbIDLibro";
            this.tbIDLibro.Size = new System.Drawing.Size(278, 20);
            this.tbIDLibro.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID libro:";
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn4});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(31, 280);
            this.librosPrestadosDataGridView.MultiSelect = false;
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.ReadOnly = true;
            this.librosPrestadosDataGridView.RowHeadersVisible = false;
            this.librosPrestadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(448, 287);
            this.librosPrestadosDataGridView.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha préstamo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha devolución";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // dS_Configuracion
            // 
            this.dS_Configuracion.DataSetName = "DS_Configuracion";
            this.dS_Configuracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configuracionBindingSource
            // 
            this.configuracionBindingSource.DataMember = "configuracion";
            this.configuracionBindingSource.DataSource = this.dS_Configuracion;
            // 
            // configuracionTableAdapter
            // 
            this.configuracionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configuracionTableAdapter = this.configuracionTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_ConfiguracionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_Prestamos
            // 
            this.dS_Prestamos.DataSetName = "DS_Prestamos";
            this.dS_Prestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "prestamos";
            this.prestamosBindingSource.DataSource = this.dS_Prestamos;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // FM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1018, 700);
            this.Controls.Add(this.librosPrestadosDataGridView);
            this.Controls.Add(this.gbBusquedaLibro);
            this.Controls.Add(this.gbBusquedaLector);
            this.Name = "FM_Prestamos";
            this.Load += new System.EventHandler(this.FM_Prestamos_Load);
            this.gbBusquedaLector.ResumeLayout(false);
            this.gbBusquedaLector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.gbBusquedaLibro.ResumeLayout(false);
            this.gbBusquedaLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBusquedaLector;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.Button bBuscarIDLector;
        private System.Windows.Forms.TextBox tbNombreBusqueda;
        private System.Windows.Forms.TextBox tbIDBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBusquedaLibro;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.Label id_lecLabel1;
        private System.Windows.Forms.Label nombre_lecLabel1;
        private System.Windows.Forms.Label domicilio_lecLabel1;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel1;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.Button bBuscarAutor;
        private System.Windows.Forms.Button bBuscarTitulo;
        private System.Windows.Forms.Button bBuscarIDLibro;
        private System.Windows.Forms.TextBox tbAutorLibro;
        private System.Windows.Forms.TextBox tbTituloLibro;
        private System.Windows.Forms.TextBox tbIDLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private System.Windows.Forms.Button bPrestamo;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DS_Configuracion dS_Configuracion;
        private System.Windows.Forms.BindingSource configuracionBindingSource;
        private DS_ConfiguracionTableAdapters.configuracionTableAdapter configuracionTableAdapter;
        private DS_ConfiguracionTableAdapters.TableAdapterManager tableAdapterManager;
        private DS_Prestamos dS_Prestamos;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTableAdapter;
    }
}
