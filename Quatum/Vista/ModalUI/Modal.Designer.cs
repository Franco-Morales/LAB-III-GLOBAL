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
            this.panelFecha = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDescripcion = new System.Windows.Forms.Panel();
            this.panelDebe = new System.Windows.Forms.Panel();
            this.panelHaber = new System.Windows.Forms.Panel();
            this.textBox21 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet1)).BeginInit();
            this.panelFecha.SuspendLayout();
            this.panelHeader.SuspendLayout();
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
            this.textCantidad.Location = new System.Drawing.Point(144, 15);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.ReadOnly = true;
            this.textCantidad.Size = new System.Drawing.Size(32, 20);
            this.textCantidad.TabIndex = 1;
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(21, 12);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(46, 23);
            this.btnAumentar.TabIndex = 2;
            this.btnAumentar.Text = "+";
            this.btnAumentar.UseVisualStyleBackColor = true;
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Location = new System.Drawing.Point(73, 12);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(46, 23);
            this.btnDisminuir.TabIndex = 3;
            this.btnDisminuir.Text = "-";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese la cantidad de cuentas a usar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(380, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // panelFecha
            // 
            this.panelFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFecha.Controls.Add(this.textBox21);
            this.panelFecha.Location = new System.Drawing.Point(1, 72);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(118, 141);
            this.panelFecha.TabIndex = 7;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.label5);
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Location = new System.Drawing.Point(1, 50);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(606, 23);
            this.panelHeader.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Haber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Debe";
            // 
            // panelDescripcion
            // 
            this.panelDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDescripcion.Location = new System.Drawing.Point(117, 72);
            this.panelDescripcion.Name = "panelDescripcion";
            this.panelDescripcion.Size = new System.Drawing.Size(290, 141);
            this.panelDescripcion.TabIndex = 7;
            // 
            // panelDebe
            // 
            this.panelDebe.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDebe.Location = new System.Drawing.Point(403, 72);
            this.panelDebe.Name = "panelDebe";
            this.panelDebe.Size = new System.Drawing.Size(99, 141);
            this.panelDebe.TabIndex = 8;
            // 
            // panelHaber
            // 
            this.panelHaber.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHaber.Location = new System.Drawing.Point(507, 72);
            this.panelHaber.Name = "panelHaber";
            this.panelHaber.Size = new System.Drawing.Size(99, 141);
            this.panelHaber.TabIndex = 9;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(6, 6);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 20);
            this.textBox21.TabIndex = 0;
            // 
            // Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 361);
            this.Controls.Add(this.panelHaber);
            this.Controls.Add(this.panelDebe);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFecha);
            this.Controls.Add(this.panelDescripcion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisminuir);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.textCantidad);
            this.Name = "Modal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet1)).EndInit();
            this.panelFecha.ResumeLayout(false);
            this.panelFecha.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private globalDataSet1 globalDataSet1;
        private System.Windows.Forms.BindingSource asientosBindingSource;
        private globalDataSet1TableAdapters.asientosTableAdapter asientosTableAdapter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textCantidad;
        public System.Windows.Forms.Button btnAumentar;
        public System.Windows.Forms.Button btnDisminuir;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Panel panelFecha;
        public System.Windows.Forms.Panel panelHeader;
        public System.Windows.Forms.Panel panelDescripcion;
        public System.Windows.Forms.Panel panelDebe;
        public System.Windows.Forms.Panel panelHaber;
        private System.Windows.Forms.TextBox textBox21;

    }
}