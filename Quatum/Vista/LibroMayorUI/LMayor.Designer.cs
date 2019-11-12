namespace Quatum.Vista.LibroMayorUI
{
    partial class LMayor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LMayor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cmbFecha = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.PictureBox();
            this.saldoTxt = new System.Windows.Forms.TextBox();
            this.saldoLbl = new System.Windows.Forms.Label();
            this.dataGridLibroMayor = new System.Windows.Forms.DataGridView();
            this.fechaLibroMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionLibroMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoLibroMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debeHaberLibroMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLibroMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroDiarioDatos = new Quatum.LibroDiarioDatos();
            this.tablaDatosTableAdapter = new Quatum.LibroDiarioDatosTableAdapters.TablaDatosTableAdapter();
            this.globalDataSet1 = new Quatum.globalDataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibroMayor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroDiarioDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 94);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCuenta);
            this.groupBox2.Location = new System.Drawing.Point(456, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por cuenta";
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Items.AddRange(new object[] {
            "Todo"});
            this.cmbCuenta.Location = new System.Drawing.Point(10, 20);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(121, 21);
            this.cmbCuenta.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbHasta);
            this.groupBox1.Controls.Add(this.cmbFecha);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(234, 34);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(196, 21);
            this.cmbHasta.TabIndex = 1;
            // 
            // cmbFecha
            // 
            this.cmbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFecha.FormattingEnabled = true;
            this.cmbFecha.Location = new System.Drawing.Point(6, 34);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(196, 21);
            this.cmbFecha.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridLibroMayor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 356);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnExportar);
            this.panel3.Controls.Add(this.saldoTxt);
            this.panel3.Controls.Add(this.saldoLbl);
            this.panel3.Location = new System.Drawing.Point(3, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 100);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Exportar libro mayor a excel";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(728, 52);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(57, 39);
            this.btnExportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExportar.TabIndex = 2;
            this.btnExportar.TabStop = false;
            // 
            // saldoTxt
            // 
            this.saldoTxt.Location = new System.Drawing.Point(166, 15);
            this.saldoTxt.Name = "saldoTxt";
            this.saldoTxt.ReadOnly = true;
            this.saldoTxt.Size = new System.Drawing.Size(100, 20);
            this.saldoTxt.TabIndex = 1;
            // 
            // saldoLbl
            // 
            this.saldoLbl.AutoSize = true;
            this.saldoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoLbl.Location = new System.Drawing.Point(9, 18);
            this.saldoLbl.Name = "saldoLbl";
            this.saldoLbl.Size = new System.Drawing.Size(80, 17);
            this.saldoLbl.TabIndex = 0;
            this.saldoLbl.Text = "Saldo Total";
            // 
            // dataGridLibroMayor
            // 
            this.dataGridLibroMayor.AllowUserToAddRows = false;
            this.dataGridLibroMayor.AllowUserToDeleteRows = false;
            this.dataGridLibroMayor.AutoGenerateColumns = false;
            this.dataGridLibroMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLibroMayor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaLibroMayor,
            this.descripcionLibroMayor,
            this.saldoLibroMayor,
            this.debeHaberLibroMayor,
            this.tipoLibroMayor});
            this.dataGridLibroMayor.DataSource = this.tablaDatosBindingSource;
            this.dataGridLibroMayor.Location = new System.Drawing.Point(0, 0);
            this.dataGridLibroMayor.Name = "dataGridLibroMayor";
            this.dataGridLibroMayor.ReadOnly = true;
            this.dataGridLibroMayor.Size = new System.Drawing.Size(797, 251);
            this.dataGridLibroMayor.TabIndex = 0;
            // 
            // fechaLibroMayor
            // 
            this.fechaLibroMayor.DataPropertyName = "asiento_fecha";
            this.fechaLibroMayor.HeaderText = "Fecha";
            this.fechaLibroMayor.Name = "fechaLibroMayor";
            this.fechaLibroMayor.ReadOnly = true;
            this.fechaLibroMayor.Width = 200;
            // 
            // descripcionLibroMayor
            // 
            this.descripcionLibroMayor.DataPropertyName = "cuentas_descripcion";
            this.descripcionLibroMayor.HeaderText = "Descripcion";
            this.descripcionLibroMayor.Name = "descripcionLibroMayor";
            this.descripcionLibroMayor.ReadOnly = true;
            this.descripcionLibroMayor.Width = 150;
            // 
            // saldoLibroMayor
            // 
            this.saldoLibroMayor.DataPropertyName = "asiento_valor";
            this.saldoLibroMayor.HeaderText = "Saldo";
            this.saldoLibroMayor.Name = "saldoLibroMayor";
            this.saldoLibroMayor.ReadOnly = true;
            // 
            // debeHaberLibroMayor
            // 
            this.debeHaberLibroMayor.DataPropertyName = "asiento_tipo";
            this.debeHaberLibroMayor.HeaderText = "Debe/Haber";
            this.debeHaberLibroMayor.Name = "debeHaberLibroMayor";
            this.debeHaberLibroMayor.ReadOnly = true;
            // 
            // tipoLibroMayor
            // 
            this.tipoLibroMayor.DataPropertyName = "cuenta_tipo";
            this.tipoLibroMayor.HeaderText = "Tipo";
            this.tipoLibroMayor.Name = "tipoLibroMayor";
            this.tipoLibroMayor.ReadOnly = true;
            // 
            // tablaDatosBindingSource
            // 
            this.tablaDatosBindingSource.DataMember = "TablaDatos";
            this.tablaDatosBindingSource.DataSource = this.libroDiarioDatos;
            // 
            // libroDiarioDatos
            // 
            this.libroDiarioDatos.DataSetName = "LibroDiarioDatos";
            this.libroDiarioDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaDatosTableAdapter
            // 
            this.tablaDatosTableAdapter.ClearBeforeFill = true;
            // 
            // globalDataSet1
            // 
            this.globalDataSet1.DataSetName = "globalDataSet";
            this.globalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LMayor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LMayor";
            this.Load += new System.EventHandler(this.LMayor_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibroMayor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroDiarioDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private LibroDiarioDatos libroDiarioDatos;
        private System.Windows.Forms.BindingSource tablaDatosBindingSource;
        private LibroDiarioDatosTableAdapters.TablaDatosTableAdapter tablaDatosTableAdapter;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox saldoTxt;
        public System.Windows.Forms.Label saldoLbl;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbFecha;
        public System.Windows.Forms.ComboBox cmbCuenta;
        public System.Windows.Forms.DataGridView dataGridLibroMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLibroMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionLibroMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoLibroMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn debeHaberLibroMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLibroMayor;
        public System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private globalDataSet globalDataSet1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox btnExportar;
    }
}