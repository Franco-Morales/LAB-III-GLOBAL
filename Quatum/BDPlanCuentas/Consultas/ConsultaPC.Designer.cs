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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.Modificar = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cuentas = new System.Windows.Forms.GroupBox();
            this.pnlMiddel = new System.Windows.Forms.Panel();
            this.cuentasdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentatipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plancuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalDataSet = new Quatum.globalDataSet();
            this.plan_cuentasTableAdapter = new Quatum.globalDataSetTableAdapters.plan_cuentasTableAdapter();
            this.pNToolStrip = new System.Windows.Forms.ToolStrip();
            this.pNToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.Modificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Cuentas.SuspendLayout();
            this.pnlMiddel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plancuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet)).BeginInit();
            this.pNToolStrip.SuspendLayout();
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
            this.dataSet.AutoGenerateColumns = false;
            this.dataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuentasdescripcionDataGridViewTextBoxColumn,
            this.cuentatipoDataGridViewTextBoxColumn});
            this.dataSet.DataSource = this.plancuentasBindingSource;
            this.dataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSet.Location = new System.Drawing.Point(0, 0);
            this.dataSet.Name = "dataSet";
            this.dataSet.Size = new System.Drawing.Size(384, 311);
            this.dataSet.TabIndex = 1;
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
            this.Modificar.Controls.Add(this.pictureBox4);
            this.Modificar.Controls.Add(this.pictureBox3);
            this.Modificar.Controls.Add(this.pictureBox2);
            this.Modificar.Controls.Add(this.pictureBox1);
            this.Modificar.Location = new System.Drawing.Point(222, 12);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(150, 82);
            this.Modificar.TabIndex = 2;
            this.Modificar.TabStop = false;
            this.Modificar.Text = "Modificar plan de Cuenta";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(114, 46);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(78, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.pnlMiddel.Controls.Add(this.dataSet);
            this.pnlMiddel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddel.Location = new System.Drawing.Point(0, 100);
            this.pnlMiddel.Name = "pnlMiddel";
            this.pnlMiddel.Size = new System.Drawing.Size(384, 311);
            this.pnlMiddel.TabIndex = 4;
            // 
            // cuentasdescripcionDataGridViewTextBoxColumn
            // 
            this.cuentasdescripcionDataGridViewTextBoxColumn.DataPropertyName = "cuentas_descripcion";
            this.cuentasdescripcionDataGridViewTextBoxColumn.HeaderText = "cuentas_descripcion";
            this.cuentasdescripcionDataGridViewTextBoxColumn.Name = "cuentasdescripcionDataGridViewTextBoxColumn";
            this.cuentasdescripcionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cuentasdescripcionDataGridViewTextBoxColumn.Width = 150;
            // 
            // cuentatipoDataGridViewTextBoxColumn
            // 
            this.cuentatipoDataGridViewTextBoxColumn.DataPropertyName = "cuenta_tipo";
            this.cuentatipoDataGridViewTextBoxColumn.HeaderText = "cuenta_tipo";
            this.cuentatipoDataGridViewTextBoxColumn.Name = "cuentatipoDataGridViewTextBoxColumn";
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
            // plan_cuentasTableAdapter
            // 
            this.plan_cuentasTableAdapter.ClearBeforeFill = true;
            // 
            // pNToolStrip
            // 
            this.pNToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pNToolStripButton});
            this.pNToolStrip.Location = new System.Drawing.Point(0, 0);
            this.pNToolStrip.Name = "pNToolStrip";
            this.pNToolStrip.Size = new System.Drawing.Size(111, 25);
            this.pNToolStrip.TabIndex = 5;
            this.pNToolStrip.Text = "pNToolStrip";
            // 
            // pNToolStripButton
            // 
            this.pNToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pNToolStripButton.Name = "pNToolStripButton";
            this.pNToolStripButton.Size = new System.Drawing.Size(27, 22);
            this.pNToolStripButton.Text = "PN";
            this.pNToolStripButton.Click += new System.EventHandler(this.pNToolStripButton_Click);
            // 
            // ConsultaPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.pNToolStrip);
            this.Controls.Add(this.pnlMiddel);
            this.Controls.Add(this.pnlTop);
            this.Name = "ConsultaPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaPC";
            this.Load += new System.EventHandler(this.ConsultaPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.Modificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Cuentas.ResumeLayout(false);
            this.pnlMiddel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plancuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet)).EndInit();
            this.pNToolStrip.ResumeLayout(false);
            this.pNToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox seleccionarTipo;
        private System.Windows.Forms.DataGridView dataSet;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMiddel;
        private System.Windows.Forms.GroupBox Cuentas;
        private System.Windows.Forms.GroupBox Modificar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private globalDataSet globalDataSet;
        private System.Windows.Forms.BindingSource plancuentasBindingSource;
        private globalDataSetTableAdapters.plan_cuentasTableAdapter plan_cuentasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentasdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentatipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip pNToolStrip;
        private System.Windows.Forms.ToolStripButton pNToolStripButton;
    }
}