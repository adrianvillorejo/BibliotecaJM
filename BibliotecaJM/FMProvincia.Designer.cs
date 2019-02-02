namespace BibliotecaJM
{
    partial class FMProvincia
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
            this.components = new System.ComponentModel.Container();
            this.dS_Provincias = new BibliotecaJM.DS_Provincias();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasTableAdapter = new BibliotecaJM.DS_ProvinciasTableAdapters.provinciasTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_ProvinciasTableAdapters.TableAdapterManager();
            this.provinciasDataGridView = new System.Windows.Forms.DataGridView();
            this.idproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_Provincias
            // 
            this.dS_Provincias.DataSetName = "DS_Provincias";
            this.dS_Provincias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.dS_Provincias;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.provinciasTableAdapter = this.provinciasTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_ProvinciasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // provinciasDataGridView
            // 
            this.provinciasDataGridView.AllowUserToAddRows = false;
            this.provinciasDataGridView.AllowUserToDeleteRows = false;
            this.provinciasDataGridView.AutoGenerateColumns = false;
            this.provinciasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provinciasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproDataGridViewTextBoxColumn,
            this.provinciaproDataGridViewTextBoxColumn});
            this.provinciasDataGridView.DataSource = this.provinciasBindingSource;
            this.provinciasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.provinciasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.provinciasDataGridView.MultiSelect = false;
            this.provinciasDataGridView.Name = "provinciasDataGridView";
            this.provinciasDataGridView.ReadOnly = true;
            this.provinciasDataGridView.RowHeadersVisible = false;
            this.provinciasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.provinciasDataGridView.Size = new System.Drawing.Size(204, 450);
            this.provinciasDataGridView.TabIndex = 1;
            this.provinciasDataGridView.DoubleClick += new System.EventHandler(this.provinciasDataGridView_DoubleClick);
            // 
            // idproDataGridViewTextBoxColumn
            // 
            this.idproDataGridViewTextBoxColumn.DataPropertyName = "id_pro";
            this.idproDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idproDataGridViewTextBoxColumn.Name = "idproDataGridViewTextBoxColumn";
            this.idproDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinciaproDataGridViewTextBoxColumn
            // 
            this.provinciaproDataGridViewTextBoxColumn.DataPropertyName = "provincia_pro";
            this.provinciaproDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaproDataGridViewTextBoxColumn.Name = "provinciaproDataGridViewTextBoxColumn";
            this.provinciaproDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FMProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 450);
            this.Controls.Add(this.provinciasDataGridView);
            this.Name = "FMProvincia";
            this.Text = "FMProvincia";
            this.Load += new System.EventHandler(this.FMProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Provincias dS_Provincias;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private DS_ProvinciasTableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private DS_ProvinciasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView provinciasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaproDataGridViewTextBoxColumn;
    }
}