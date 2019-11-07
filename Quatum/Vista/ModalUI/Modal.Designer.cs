namespace Quatum.Vista.ModalUI
{
    partial class Modal
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
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pblTop = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.cargarBD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridProvisorio = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.GBoxDebeHaber = new System.Windows.Forms.GroupBox();
            this.checkBoxHaber = new System.Windows.Forms.CheckBox();
            this.checkBoxDebe = new System.Windows.Forms.CheckBox();
            this.GBoxDescripcion = new System.Windows.Forms.GroupBox();
            this.seleccionarCuenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.GBoxFecha = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.globalDataSet = new Quatum.globalDataSet();
            this.globalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plancuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plan_cuentasTableAdapter = new Quatum.globalDataSetTableAdapters.plan_cuentasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plancuentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fechaProvisoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentasdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pblTop.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvisorio)).BeginInit();
            this.GBoxDebeHaber.SuspendLayout();
            this.GBoxDescripcion.SuspendLayout();
            this.GBoxFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plancuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plancuentasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textCantidad
            // 
            this.textCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidad.Location = new System.Drawing.Point(87, 29);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.ReadOnly = true;
            this.textCantidad.Size = new System.Drawing.Size(32, 22);
            this.textCantidad.TabIndex = 1;
            this.textCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAumentar
            // 
            this.btnAumentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.Location = new System.Drawing.Point(12, 24);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(30, 30);
            this.btnAumentar.TabIndex = 2;
            this.btnAumentar.Text = "+";
            this.btnAumentar.UseVisualStyleBackColor = true;
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuir.Location = new System.Drawing.Point(48, 24);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(30, 30);
            this.btnDisminuir.TabIndex = 3;
            this.btnDisminuir.Text = "-";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese la cantidad de cuentas a usar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(563, 24);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // pblTop
            // 
            this.pblTop.Controls.Add(this.btnDisminuir);
            this.pblTop.Controls.Add(this.textCantidad);
            this.pblTop.Controls.Add(this.btnAumentar);
            this.pblTop.Controls.Add(this.label1);
            this.pblTop.Controls.Add(this.btnAceptar);
            this.pblTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblTop.Location = new System.Drawing.Point(0, 0);
            this.pblTop.Name = "pblTop";
            this.pblTop.Size = new System.Drawing.Size(650, 88);
            this.pblTop.TabIndex = 10;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.dataGridView1);
            this.pnlFill.Controls.Add(this.cargarBD);
            this.pnlFill.Controls.Add(this.label3);
            this.pnlFill.Controls.Add(this.dataGridProvisorio);
            this.pnlFill.Controls.Add(this.btnEnviar);
            this.pnlFill.Controls.Add(this.GBoxDebeHaber);
            this.pnlFill.Controls.Add(this.GBoxDescripcion);
            this.pnlFill.Controls.Add(this.GBoxFecha);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 88);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(650, 273);
            this.pnlFill.TabIndex = 11;
            // 
            // cargarBD
            // 
            this.cargarBD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cargarBD.FlatAppearance.BorderSize = 2;
            this.cargarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargarBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargarBD.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cargarBD.Location = new System.Drawing.Point(522, 137);
            this.cargarBD.Name = "cargarBD";
            this.cargarBD.Size = new System.Drawing.Size(116, 50);
            this.cargarBD.TabIndex = 5;
            this.cargarBD.Text = "Cargar al libro Diario";
            this.cargarBD.UseVisualStyleBackColor = true;
            this.cargarBD.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Libro Diario Provisorio";
            // 
            // dataGridProvisorio
            // 
            this.dataGridProvisorio.AllowUserToAddRows = false;
            this.dataGridProvisorio.AllowUserToDeleteRows = false;
            this.dataGridProvisorio.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridProvisorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProvisorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProvisorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaProvisoria,
            this.saldo,
            this.tipo});
            this.dataGridProvisorio.Location = new System.Drawing.Point(12, 125);
            this.dataGridProvisorio.MultiSelect = false;
            this.dataGridProvisorio.Name = "dataGridProvisorio";
            this.dataGridProvisorio.ReadOnly = true;
            this.dataGridProvisorio.RowHeadersVisible = false;
            this.dataGridProvisorio.Size = new System.Drawing.Size(504, 136);
            this.dataGridProvisorio.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.DimGray;
            this.btnEnviar.Location = new System.Drawing.Point(522, 211);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(116, 50);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Cargar cuenta";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // GBoxDebeHaber
            // 
            this.GBoxDebeHaber.Controls.Add(this.checkBoxHaber);
            this.GBoxDebeHaber.Controls.Add(this.checkBoxDebe);
            this.GBoxDebeHaber.Location = new System.Drawing.Point(538, 6);
            this.GBoxDebeHaber.Name = "GBoxDebeHaber";
            this.GBoxDebeHaber.Size = new System.Drawing.Size(100, 88);
            this.GBoxDebeHaber.TabIndex = 1;
            this.GBoxDebeHaber.TabStop = false;
            this.GBoxDebeHaber.Text = "Tipo de Cuenta";
            // 
            // checkBoxHaber
            // 
            this.checkBoxHaber.AutoSize = true;
            this.checkBoxHaber.Location = new System.Drawing.Point(7, 45);
            this.checkBoxHaber.Name = "checkBoxHaber";
            this.checkBoxHaber.Size = new System.Drawing.Size(55, 17);
            this.checkBoxHaber.TabIndex = 1;
            this.checkBoxHaber.Text = "Haber";
            this.checkBoxHaber.UseVisualStyleBackColor = true;
            // 
            // checkBoxDebe
            // 
            this.checkBoxDebe.AutoSize = true;
            this.checkBoxDebe.Location = new System.Drawing.Point(7, 22);
            this.checkBoxDebe.Name = "checkBoxDebe";
            this.checkBoxDebe.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDebe.TabIndex = 0;
            this.checkBoxDebe.Text = "Debe";
            this.checkBoxDebe.UseVisualStyleBackColor = true;
            // 
            // GBoxDescripcion
            // 
            this.GBoxDescripcion.Controls.Add(this.seleccionarCuenta);
            this.GBoxDescripcion.Controls.Add(this.label2);
            this.GBoxDescripcion.Controls.Add(this.txtMonto);
            this.GBoxDescripcion.Location = new System.Drawing.Point(175, 6);
            this.GBoxDescripcion.Name = "GBoxDescripcion";
            this.GBoxDescripcion.Size = new System.Drawing.Size(357, 88);
            this.GBoxDescripcion.TabIndex = 1;
            this.GBoxDescripcion.TabStop = false;
            this.GBoxDescripcion.Text = "Descripción";
            // 
            // seleccionarCuenta
            // 
            this.seleccionarCuenta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.seleccionarCuenta.Location = new System.Drawing.Point(7, 24);
            this.seleccionarCuenta.Name = "seleccionarCuenta";
            this.seleccionarCuenta.Size = new System.Drawing.Size(111, 25);
            this.seleccionarCuenta.TabIndex = 3;
            this.seleccionarCuenta.Text = "Seleccionar Cuenta";
            this.seleccionarCuenta.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(294, 19);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(57, 22);
            this.txtMonto.TabIndex = 1;
            // 
            // GBoxFecha
            // 
            this.GBoxFecha.Controls.Add(this.dateTimePicker1);
            this.GBoxFecha.Location = new System.Drawing.Point(19, 6);
            this.GBoxFecha.Name = "GBoxFecha";
            this.GBoxFecha.Size = new System.Drawing.Size(150, 88);
            this.GBoxFecha.TabIndex = 0;
            this.GBoxFecha.TabStop = false;
            this.GBoxFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // globalDataSet
            // 
            this.globalDataSet.DataSetName = "globalDataSet";
            this.globalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // globalDataSetBindingSource
            // 
            this.globalDataSetBindingSource.DataSource = this.globalDataSet;
            this.globalDataSetBindingSource.Position = 0;
            // 
            // plancuentasBindingSource
            // 
            this.plancuentasBindingSource.DataMember = "plan_cuentas";
            this.plancuentasBindingSource.DataSource = this.globalDataSetBindingSource;
            // 
            // plan_cuentasTableAdapter
            // 
            this.plan_cuentasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuentasdescripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.plancuentasBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(202, 125);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(117, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // plancuentasBindingSource1
            // 
            this.plancuentasBindingSource1.DataMember = "plan_cuentas";
            this.plancuentasBindingSource1.DataSource = this.globalDataSetBindingSource;
            // 
            // fechaProvisoria
            // 
            this.fechaProvisoria.HeaderText = "Fecha";
            this.fechaProvisoria.Name = "fechaProvisoria";
            this.fechaProvisoria.ReadOnly = true;
            this.fechaProvisoria.Width = 300;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Debe/Haber";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // cuentasdescripcionDataGridViewTextBoxColumn
            // 
            this.cuentasdescripcionDataGridViewTextBoxColumn.DataPropertyName = "cuentas_descripcion";
            this.cuentasdescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.cuentasdescripcionDataGridViewTextBoxColumn.Name = "cuentasdescripcionDataGridViewTextBoxColumn";
            this.cuentasdescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuentasdescripcionDataGridViewTextBoxColumn.Width = 115;
            // 
            // Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 361);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pblTop);
            this.Name = "Modal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Modal_Load);
            this.pblTop.ResumeLayout(false);
            this.pblTop.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvisorio)).EndInit();
            this.GBoxDebeHaber.ResumeLayout(false);
            this.GBoxDebeHaber.PerformLayout();
            this.GBoxDescripcion.ResumeLayout(false);
            this.GBoxDescripcion.PerformLayout();
            this.GBoxFecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plancuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plancuentasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textCantidad;
        public System.Windows.Forms.Button btnAumentar;
        public System.Windows.Forms.Button btnDisminuir;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox GBoxDebeHaber;
        private System.Windows.Forms.GroupBox GBoxFecha;
        public System.Windows.Forms.Panel pblTop;
        public System.Windows.Forms.Panel pnlFill;
        public System.Windows.Forms.CheckBox checkBoxHaber;
        public System.Windows.Forms.CheckBox checkBoxDebe;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMonto;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button btnEnviar;
        public System.Windows.Forms.GroupBox GBoxDescripcion;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridProvisorio;
        public System.Windows.Forms.Button cargarBD;
        public System.Windows.Forms.Button seleccionarCuenta;
        private System.Windows.Forms.BindingSource globalDataSetBindingSource;
        private globalDataSet globalDataSet;
        private System.Windows.Forms.BindingSource plancuentasBindingSource;
        private globalDataSetTableAdapters.plan_cuentasTableAdapter plan_cuentasTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource plancuentasBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaProvisoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentasdescripcionDataGridViewTextBoxColumn;
    }
}