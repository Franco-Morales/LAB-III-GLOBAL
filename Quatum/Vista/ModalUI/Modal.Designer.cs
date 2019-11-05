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
            this.asientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalDataSet1 = new Quatum.globalDataSet1();
            this.asientosTableAdapter = new Quatum.globalDataSet1TableAdapters.asientosTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pblTop = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.GBoxFecha = new System.Windows.Forms.GroupBox();
            this.GBoxDescripcion = new System.Windows.Forms.GroupBox();
            this.GBoxDebeHaber = new System.Windows.Forms.GroupBox();
            this.txtBoxFecha = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxDebe = new System.Windows.Forms.CheckBox();
            this.checkBoxHaber = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet1)).BeginInit();
            this.pblTop.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.GBoxFecha.SuspendLayout();
            this.GBoxDescripcion.SuspendLayout();
            this.GBoxDebeHaber.SuspendLayout();
            this.SuspendLayout();
            // 
            // asientosBindingSource
            // 
            this.asientosBindingSource.DataMember = "asientos";
            this.asientosBindingSource.DataSource = this.globalDataSet1;
            // 
            // globalDataSet1
            // 
            this.globalDataSet1.DataSetName = "globalDataSet1";
            this.globalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asientosTableAdapter
            // 
            this.asientosTableAdapter.ClearBeforeFill = true;
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
            // GBoxFecha
            // 
            this.GBoxFecha.Controls.Add(this.dateTimePicker1);
            this.GBoxFecha.Controls.Add(this.txtBoxFecha);
            this.GBoxFecha.Location = new System.Drawing.Point(19, 6);
            this.GBoxFecha.Name = "GBoxFecha";
            this.GBoxFecha.Size = new System.Drawing.Size(150, 100);
            this.GBoxFecha.TabIndex = 0;
            this.GBoxFecha.TabStop = false;
            this.GBoxFecha.Text = "Fecha";
            // 
            // GBoxDescripcion
            // 
            this.GBoxDescripcion.Controls.Add(this.label2);
            this.GBoxDescripcion.Controls.Add(this.textBox1);
            this.GBoxDescripcion.Controls.Add(this.comboBox1);
            this.GBoxDescripcion.Location = new System.Drawing.Point(175, 6);
            this.GBoxDescripcion.Name = "GBoxDescripcion";
            this.GBoxDescripcion.Size = new System.Drawing.Size(357, 100);
            this.GBoxDescripcion.TabIndex = 1;
            this.GBoxDescripcion.TabStop = false;
            this.GBoxDescripcion.Text = "Descripción";
            // 
            // GBoxDebeHaber
            // 
            this.GBoxDebeHaber.Controls.Add(this.checkBoxHaber);
            this.GBoxDebeHaber.Controls.Add(this.checkBoxDebe);
            this.GBoxDebeHaber.Location = new System.Drawing.Point(538, 6);
            this.GBoxDebeHaber.Name = "GBoxDebeHaber";
            this.GBoxDebeHaber.Size = new System.Drawing.Size(100, 100);
            this.GBoxDebeHaber.TabIndex = 1;
            this.GBoxDebeHaber.TabStop = false;
            this.GBoxDebeHaber.Text = "Tipo de Cuenta";
            // 
            // txtBoxFecha
            // 
            this.txtBoxFecha.Location = new System.Drawing.Point(7, 20);
            this.txtBoxFecha.Name = "txtBoxFecha";
            this.txtBoxFecha.Size = new System.Drawing.Size(137, 20);
            this.txtBoxFecha.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 0;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(294, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto";
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(538, 211);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 50);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Cargar cuenta";
            this.btnEnviar.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet1)).EndInit();
            this.pblTop.ResumeLayout(false);
            this.pblTop.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            this.GBoxFecha.ResumeLayout(false);
            this.GBoxFecha.PerformLayout();
            this.GBoxDescripcion.ResumeLayout(false);
            this.GBoxDescripcion.PerformLayout();
            this.GBoxDebeHaber.ResumeLayout(false);
            this.GBoxDebeHaber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private globalDataSet1 globalDataSet1;
        private System.Windows.Forms.BindingSource asientosBindingSource;
        private globalDataSet1TableAdapters.asientosTableAdapter asientosTableAdapter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.TextBox textCantidad;
        public System.Windows.Forms.Button btnAumentar;
        public System.Windows.Forms.Button btnDisminuir;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox GBoxDebeHaber;
        private System.Windows.Forms.CheckBox checkBoxHaber;
        private System.Windows.Forms.CheckBox checkBoxDebe;
        private System.Windows.Forms.GroupBox GBoxDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox GBoxFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxFecha;
        public System.Windows.Forms.Panel pblTop;
        public System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Button btnEnviar;
    }
}