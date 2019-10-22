namespace Quatum.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibroDiario));
            this.pnlUno = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCLOSE = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Container = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.actions = new System.Windows.Forms.Panel();
            this.pnlUno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLOSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Container.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.actions.SuspendLayout();
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(800, 349);
            this.dataGridView.TabIndex = 0;
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
            this.pnlData.Controls.Add(this.dataGridView);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 70);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(800, 349);
            this.pnlData.TabIndex = 3;
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
            this.pnlUno.ResumeLayout(false);
            this.pnlUno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLOSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Container.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.actions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUno;
        public System.Windows.Forms.PictureBox btnCLOSE;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel actions;
    }
}