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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalDataSet1 = new Quatum.globalDataSet1();
            this.asientosTableAdapter = new Quatum.globalDataSet1TableAdapters.asientosTableAdapter();
            this.asiento_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientofechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientovalorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientotipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiento_referencia,
            this.asientofechaDataGridViewTextBoxColumn,
            this.cuentasDataGridViewTextBoxColumn,
            this.asientovalorDataGridViewTextBoxColumn,
            this.asientotipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asientosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(684, 197);
            this.dataGridView1.TabIndex = 0;
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
            // asiento_referencia
            // 
            this.asiento_referencia.DataPropertyName = "asiento_referencia";
            this.asiento_referencia.HeaderText = "asiento_referencia";
            this.asiento_referencia.Name = "asiento_referencia";
            this.asiento_referencia.ReadOnly = true;
            // 
            // asientofechaDataGridViewTextBoxColumn
            // 
            this.asientofechaDataGridViewTextBoxColumn.DataPropertyName = "asiento_fecha";
            this.asientofechaDataGridViewTextBoxColumn.HeaderText = "asiento_fecha";
            this.asientofechaDataGridViewTextBoxColumn.Name = "asientofechaDataGridViewTextBoxColumn";
            this.asientofechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuentasDataGridViewTextBoxColumn
            // 
            this.cuentasDataGridViewTextBoxColumn.DataPropertyName = "cuentas";
            this.cuentasDataGridViewTextBoxColumn.HeaderText = "cuentas";
            this.cuentasDataGridViewTextBoxColumn.Name = "cuentasDataGridViewTextBoxColumn";
            this.cuentasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asientovalorDataGridViewTextBoxColumn
            // 
            this.asientovalorDataGridViewTextBoxColumn.DataPropertyName = "asiento_valor";
            this.asientovalorDataGridViewTextBoxColumn.HeaderText = "asiento_valor";
            this.asientovalorDataGridViewTextBoxColumn.Name = "asientovalorDataGridViewTextBoxColumn";
            this.asientovalorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asientotipoDataGridViewTextBoxColumn
            // 
            this.asientotipoDataGridViewTextBoxColumn.DataPropertyName = "asiento_tipo";
            this.asientotipoDataGridViewTextBoxColumn.HeaderText = "asiento_tipo";
            this.asientotipoDataGridViewTextBoxColumn.Name = "asientotipoDataGridViewTextBoxColumn";
            this.asientotipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Modal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Modal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private globalDataSet1 globalDataSet1;
        private System.Windows.Forms.BindingSource asientosBindingSource;
        private globalDataSet1TableAdapters.asientosTableAdapter asientosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiento_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientofechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientovalorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientotipoDataGridViewTextBoxColumn;

    }
}