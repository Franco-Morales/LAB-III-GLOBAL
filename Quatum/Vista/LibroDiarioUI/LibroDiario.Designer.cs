namespace Quatum.Vista.LibroDiarioUI
{
    partial class LibroDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibroDiario));
            this.pnlUno = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCLOSE = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Container = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asientofechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentasdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientovalorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientotipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actions = new System.Windows.Forms.Panel();
            this.dataTable1TableAdapter = new Quatum.globalDataSetLibroDiarioTableAdapters.DataTable1TableAdapter();
            this.tablaDatosTableAdapter = new Quatum.LibroDiarioDatosTableAdapters.TablaDatosTableAdapter();
            this.libroDiarioDatos = new Quatum.LibroDiarioDatos();
            this.tablaDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalDataSetLibroDiario = new Quatum.globalDataSetLibroDiario();
            this.globalDataSetLibroDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaDatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlUno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLOSE)).BeginInit();
            this.Container.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libroDiarioDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSetLibroDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSetLibroDiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUno
            // 
            this.pnlUno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.pnlUno.Controls.Add(this.lblTitle);
            this.pnlUno.Controls.Add(this.btnCLOSE);
            this.pnlUno.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUno.Location = new System.Drawing.Point(0, 0);
            this.pnlUno.Name = "pnlUno";
            this.pnlUno.Size = new System.Drawing.Size(800, 31);
            this.pnlUno.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 19);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Libro Diario";
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLOSE.Image = ((System.Drawing.Image)(resources.GetObject("btnCLOSE.Image")));
            this.btnCLOSE.Location = new System.Drawing.Point(772, 3);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(25, 25);
            this.btnCLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCLOSE.TabIndex = 5;
            this.btnCLOSE.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Container
            // 
            this.Container.Controls.Add(this.pnlData);
            this.Container.Controls.Add(this.actions);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 31);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(800, 419);
            this.Container.TabIndex = 3;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dataGridView1);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 70);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(800, 349);
            this.pnlData.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asientofechaDataGridViewTextBoxColumn,
            this.cuentasdescripcionDataGridViewTextBoxColumn,
            this.asientovalorDataGridViewTextBoxColumn,
            this.asientotipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablaDatosBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // asientofechaDataGridViewTextBoxColumn
            // 
            this.asientofechaDataGridViewTextBoxColumn.DataPropertyName = "asiento_fecha";
            this.asientofechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.asientofechaDataGridViewTextBoxColumn.Name = "asientofechaDataGridViewTextBoxColumn";
            this.asientofechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.asientofechaDataGridViewTextBoxColumn.Width = 200;
            // 
            // cuentasdescripcionDataGridViewTextBoxColumn
            // 
            this.cuentasdescripcionDataGridViewTextBoxColumn.DataPropertyName = "cuentas_descripcion";
            this.cuentasdescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.cuentasdescripcionDataGridViewTextBoxColumn.Name = "cuentasdescripcionDataGridViewTextBoxColumn";
            this.cuentasdescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asientovalorDataGridViewTextBoxColumn
            // 
            this.asientovalorDataGridViewTextBoxColumn.DataPropertyName = "asiento_valor";
            this.asientovalorDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.asientovalorDataGridViewTextBoxColumn.Name = "asientovalorDataGridViewTextBoxColumn";
            this.asientovalorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asientotipoDataGridViewTextBoxColumn
            // 
            this.asientotipoDataGridViewTextBoxColumn.DataPropertyName = "asiento_tipo";
            this.asientotipoDataGridViewTextBoxColumn.HeaderText = "Debe";
            this.asientotipoDataGridViewTextBoxColumn.Name = "asientotipoDataGridViewTextBoxColumn";
            this.asientotipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actions
            // 
            this.actions.Controls.Add(this.btnAdd);
            this.actions.Dock = System.Windows.Forms.DockStyle.Top;
            this.actions.Location = new System.Drawing.Point(0, 0);
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(800, 70);
            this.actions.TabIndex = 2;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tablaDatosTableAdapter
            // 
            this.tablaDatosTableAdapter.ClearBeforeFill = true;
            // 
            // libroDiarioDatos
            // 
            this.libroDiarioDatos.DataSetName = "LibroDiarioDatos";
            this.libroDiarioDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaDatosBindingSource
            // 
            this.tablaDatosBindingSource.DataMember = "TablaDatos";
            this.tablaDatosBindingSource.DataSource = this.libroDiarioDatos;
            // 
            // globalDataSetLibroDiario
            // 
            this.globalDataSetLibroDiario.DataSetName = "globalDataSetLibroDiario";
            this.globalDataSetLibroDiario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // globalDataSetLibroDiarioBindingSource
            // 
            this.globalDataSetLibroDiarioBindingSource.DataSource = this.globalDataSetLibroDiario;
            this.globalDataSetLibroDiarioBindingSource.Position = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.globalDataSetLibroDiarioBindingSource;
            // 
            // tablaDatosBindingSource1
            // 
            this.tablaDatosBindingSource1.DataMember = "TablaDatos";
            this.tablaDatosBindingSource1.DataSource = this.libroDiarioDatos;
            // 
            // LibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.pnlUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibroDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LibroDiario";
            this.Load += new System.EventHandler(this.LibroDiario_Load);
            this.pnlUno.ResumeLayout(false);
            this.pnlUno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLOSE)).EndInit();
            this.Container.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libroDiarioDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSetLibroDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSetLibroDiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUno;
        public System.Windows.Forms.PictureBox btnCLOSE;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel actions;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientofechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentasdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientovalorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientotipoDataGridViewTextBoxColumn;
        private globalDataSetLibroDiarioTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private LibroDiarioDatosTableAdapters.TablaDatosTableAdapter tablaDatosTableAdapter;
        private LibroDiarioDatos libroDiarioDatos;
        private System.Windows.Forms.BindingSource tablaDatosBindingSource;
        private globalDataSetLibroDiario globalDataSetLibroDiario;
        private System.Windows.Forms.BindingSource globalDataSetLibroDiarioBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource tablaDatosBindingSource1;
    }
}