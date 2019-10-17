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
            this.seleccionarTipo = new System.Windows.Forms.ComboBox();
            this.rejilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rejilla)).BeginInit();
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
            this.seleccionarTipo.SelectedIndex = 0;
            this.seleccionarTipo.Location = new System.Drawing.Point(13, 13);
            this.seleccionarTipo.Name = "seleccionarTipo";
            this.seleccionarTipo.Size = new System.Drawing.Size(121, 21);
            this.seleccionarTipo.TabIndex = 0;
            this.seleccionarTipo.SelectedIndexChanged += new System.EventHandler(this.seleccionarTipo_SelectedIndexChanged);
            // 
            // rejilla
            // 
            this.rejilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rejilla.Location = new System.Drawing.Point(13, 52);
            this.rejilla.Name = "rejilla";
            this.rejilla.Size = new System.Drawing.Size(240, 150);
            this.rejilla.TabIndex = 1;
            // 
            // ConsultaPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rejilla);
            this.Controls.Add(this.seleccionarTipo);
            this.Name = "ConsultaPC";
            this.Text = "ConsultaPC";
            ((System.ComponentModel.ISupportInitialize)(this.rejilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox seleccionarTipo;
        private System.Windows.Forms.DataGridView rejilla;
    }
}