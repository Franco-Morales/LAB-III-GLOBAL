namespace Quatum.BDPlanCuentas.Consultas
{
    partial class ConsultaPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPC));
            this.seleccionarTipo = new System.Windows.Forms.ComboBox();
            this.dataSet = new System.Windows.Forms.DataGridView();
            this.cuentasdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentatipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plancuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalDataSet = new Quatum.globalDataSet();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.Modificar = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnMod = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.Cuentas = new System.Windows.Forms.GroupBox();
            this.pnlMiddel = new System.Windows.Forms.Panel();
            this.cuentaSeleccionada = new System.Windows.Forms.Button();
            this.plan_cuentasTableAdapter = new Quatum.globalDataSetTableAdapters.plan_cuentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plancuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.Modificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            this.Cuentas.SuspendLayout();
            this.pnlMiddel.SuspendLayout();
            this.SuspendLayout();
            // 
            // seleccionarTipo
            // 
            this.seleccionarTipo.FormattingEnabled = true;
            this.seleccionarTipo.Items.AddRange(new object[] {
            "Activos",
            "Pasivos",
            "Patrimonio Neto",
            "Ingresos ",
            "Egresos"});
            this.seleccionarTipo.Location = new System.Drawing.Point(6, 33);
            this.seleccionarTipo.Name = "seleccionarTipo";
            this.seleccionarTipo.Size = new System.Drawing.Size(121, 21);
            this.seleccionarTipo.TabIndex = 0;
            this.seleccionarTipo.SelectedIndexChanged += new System.EventHandler(this.seleccionarTipo_SelectedIndexChanged);
            // 
            // dataSet
            // 
            this.dataSet.AllowUserToAddRows = false;
            this.dataSet.AllowUserToDeleteRows = false;
            this.dataSet.AutoGenerateColumns = false;
            this.dataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuentasdescripcionDataGridViewTextBoxColumn,
            this.cuentatipoDataGridViewTextBoxColumn,
            this.Column1});
            this.dataSet.DataSource = this.plancuentasBindingSource;
            this.dataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSet.Location = new System.Drawing.Point(0, 0);
            this.dataSet.Name = "dataSet";
            this.dataSet.ReadOnly = true;
            this.dataSet.Size = new System.Drawing.Size(384, 311);
            this.dataSet.TabIndex = 1;
            // 
            // cuentasdescripcionDataGridViewTextBoxColumn
            // 
            this.cuentasdescripcionDataGridViewTextBoxColumn.DataPropertyName = "cuentas_descripcion";
            this.cuentasdescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.cuentasdescripcionDataGridViewTextBoxColumn.Name = "cuentasdescripcionDataGridViewTextBoxColumn";
            this.cuentasdescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuentasdescripcionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cuentasdescripcionDataGridViewTextBoxColumn.Width = 150;
            // 
            // cuentatipoDataGridViewTextBoxColumn
            // 
            this.cuentatipoDataGridViewTextBoxColumn.DataPropertyName = "cuenta_tipo";
            this.cuentatipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.cuentatipoDataGridViewTextBoxColumn.Name = "cuentatipoDataGridViewTextBoxColumn";
            this.cuentatipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cuentas_id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // plancuentasBindingSource
            // 
            this.plancuentasBindingSource.DataMember = "plan_cuentas";
            this.plancuentasBindingSource.DataSource = this.globalDataSet;
            // 
            // globalDataSet
            // 
            this.globalDataSet.DataSetName = "globalDataSet";
            this.globalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.Modificar);
            this.pnlTop.Controls.Add(this.Cuentas);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(384, 100);
            this.pnlTop.TabIndex = 2;
            // 
            // Modificar
            // 
            this.Modificar.Controls.Add(this.btnDelete);
            this.Modificar.Controls.Add(this.btnMod);
            this.Modificar.Controls.Add(this.btnAgregar);
            this.Modificar.Location = new System.Drawing.Point(222, 12);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(150, 82);
            this.Modificar.TabIndex = 2;
            this.Modificar.TabStop = false;
            this.Modificar.Text = "Modificar plan de Cuenta";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(114, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnMod
            // 
            this.btnMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMod.Image = ((System.Drawing.Image)(resources.GetObject("btnMod.Image")));
            this.btnMod.Location = new System.Drawing.Point(60, 46);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(30, 30);
            this.btnMod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMod.TabIndex = 1;
            this.btnMod.TabStop = false;
            this.btnMod.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(6, 46);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(30, 30);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Cuentas
            // 
            this.Cuentas.Controls.Add(this.seleccionarTipo);
            this.Cuentas.Location = new System.Drawing.Point(13, 12);
            this.Cuentas.Name = "Cuentas";
            this.Cuentas.Size = new System.Drawing.Size(133, 60);
            this.Cuentas.TabIndex = 1;
            this.Cuentas.TabStop = false;
            this.Cuentas.Text = "Cuentas";
            // 
            // pnlMiddel
            // 
            this.pnlMiddel.Controls.Add(this.cuentaSeleccionada);
            this.pnlMiddel.Controls.Add(this.dataSet);
            this.pnlMiddel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddel.Location = new System.Drawing.Point(0, 100);
            this.pnlMiddel.Name = "pnlMiddel";
            this.pnlMiddel.Size = new System.Drawing.Size(384, 311);
            this.pnlMiddel.TabIndex = 4;
            // 
            // cuentaSeleccionada
            // 
            this.cuentaSeleccionada.Location = new System.Drawing.Point(19, 206);
            this.cuentaSeleccionada.Name = "cuentaSeleccionada";
            this.cuentaSeleccionada.Size = new System.Drawing.Size(148, 34);
            this.cuentaSeleccionada.TabIndex = 2;
            this.cuentaSeleccionada.Text = "Usar Cuenta Seleccionada";
            this.cuentaSeleccionada.UseVisualStyleBackColor = true;
            this.cuentaSeleccionada.Visible = false;
            // 
            // plan_cuentasTableAdapter
            // 
            this.plan_cuentasTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultaPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.pnlMiddel);
            this.Controls.Add(this.pnlTop);
            this.Name = "ConsultaPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaPC";
            this.Load += new System.EventHandler(this.ConsultaPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plancuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.Modificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.Cuentas.ResumeLayout(false);
            this.pnlMiddel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMiddel;
        private System.Windows.Forms.GroupBox Cuentas;
        private System.Windows.Forms.GroupBox Modificar;
        private globalDataSet globalDataSet;
        private System.Windows.Forms.BindingSource plancuentasBindingSource;
        private globalDataSetTableAdapters.plan_cuentasTableAdapter plan_cuentasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentasdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentatipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridView dataSet;
        public System.Windows.Forms.PictureBox btnDelete;
        public System.Windows.Forms.PictureBox btnMod;
        public System.Windows.Forms.PictureBox btnAgregar;
        public System.Windows.Forms.ComboBox seleccionarTipo;
        public System.Windows.Forms.Button cuentaSeleccionada;
    }
}