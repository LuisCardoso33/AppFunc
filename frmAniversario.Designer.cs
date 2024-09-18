namespace AppFunc
{
    partial class frmAniversario
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
			this.btnFechar = new System.Windows.Forms.Button();
			this.dgvAniversariante = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvAniversariante)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.Color.Red;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.ForeColor = System.Drawing.Color.White;
			this.btnFechar.Location = new System.Drawing.Point(496, 12);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(106, 37);
			this.btnFechar.TabIndex = 0;
			this.btnFechar.Text = "FECHAR";
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// dgvAniversariante
			// 
			this.dgvAniversariante.AllowUserToAddRows = false;
			this.dgvAniversariante.AllowUserToDeleteRows = false;
			this.dgvAniversariante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAniversariante.Location = new System.Drawing.Point(12, 12);
			this.dgvAniversariante.Name = "dgvAniversariante";
			this.dgvAniversariante.ReadOnly = true;
			this.dgvAniversariante.Size = new System.Drawing.Size(464, 330);
			this.dgvAniversariante.TabIndex = 1;
			// 
			// frmAniversario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(641, 450);
			this.Controls.Add(this.dgvAniversariante);
			this.Controls.Add(this.btnFechar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAniversario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ANIVERSARIANTES";
			this.Load += new System.EventHandler(this.frmAniversario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAniversariante)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.DataGridView dgvAniversariante;
	}
}