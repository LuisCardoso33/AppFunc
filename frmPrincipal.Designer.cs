namespace AppFunc
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnInserir = new System.Windows.Forms.Button();
			this.cbxTurno = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.pbxAniversario = new System.Windows.Forms.PictureBox();
			this.dgvFuncionario = new System.Windows.Forms.DataGridView();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMatricula = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbxAniversario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
			this.SuspendLayout();
			// 
			// btnInserir
			// 
			this.btnInserir.BackColor = System.Drawing.Color.DarkGreen;
			this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInserir.ForeColor = System.Drawing.Color.White;
			this.btnInserir.Location = new System.Drawing.Point(446, 7);
			this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(122, 51);
			this.btnInserir.TabIndex = 0;
			this.btnInserir.Text = "INSERIR";
			this.btnInserir.UseVisualStyleBackColor = false;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// cbxTurno
			// 
			this.cbxTurno.FormattingEnabled = true;
			this.cbxTurno.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
			this.cbxTurno.Location = new System.Drawing.Point(22, 119);
			this.cbxTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbxTurno.Name = "cbxTurno";
			this.cbxTurno.Size = new System.Drawing.Size(158, 21);
			this.cbxTurno.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "ID";
			// 
			// mskDataNascimento
			// 
			this.mskDataNascimento.Location = new System.Drawing.Point(230, 120);
			this.mskDataNascimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.mskDataNascimento.Mask = "00/00/0000";
			this.mskDataNascimento.Name = "mskDataNascimento";
			this.mskDataNascimento.Size = new System.Drawing.Size(133, 20);
			this.mskDataNascimento.TabIndex = 3;
			this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(22, 23);
			this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(76, 20);
			this.txtId.TabIndex = 4;
			// 
			// pbxAniversario
			// 
			this.pbxAniversario.Image = global::AppFunc.Properties.Resources.calendario;
			this.pbxAniversario.Location = new System.Drawing.Point(446, 244);
			this.pbxAniversario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pbxAniversario.Name = "pbxAniversario";
			this.pbxAniversario.Size = new System.Drawing.Size(122, 149);
			this.pbxAniversario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxAniversario.TabIndex = 5;
			this.pbxAniversario.TabStop = false;
			this.pbxAniversario.Click += new System.EventHandler(this.pbxAniversario_Click);
			// 
			// dgvFuncionario
			// 
			this.dgvFuncionario.AllowUserToAddRows = false;
			this.dgvFuncionario.AllowUserToDeleteRows = false;
			this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFuncionario.Location = new System.Drawing.Point(22, 206);
			this.dgvFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvFuncionario.Name = "dgvFuncionario";
			this.dgvFuncionario.ReadOnly = true;
			this.dgvFuncionario.RowHeadersWidth = 51;
			this.dgvFuncionario.RowTemplate.Height = 24;
			this.dgvFuncionario.Size = new System.Drawing.Size(404, 187);
			this.dgvFuncionario.TabIndex = 6;
			this.dgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(22, 69);
			this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(341, 20);
			this.txtNome.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 54);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "NOME";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 103);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "TURNO";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(227, 103);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "DATA DE NASCIMENTO";
			// 
			// txtMatricula
			// 
			this.txtMatricula.Location = new System.Drawing.Point(22, 169);
			this.txtMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtMatricula.Name = "txtMatricula";
			this.txtMatricula.Size = new System.Drawing.Size(158, 20);
			this.txtMatricula.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 154);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 15);
			this.label5.TabIndex = 11;
			this.label5.Text = "MATRÍCULA";
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLocalizar.ForeColor = System.Drawing.Color.RoyalBlue;
			this.btnLocalizar.Location = new System.Drawing.Point(101, 7);
			this.btnLocalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(122, 51);
			this.btnLocalizar.TabIndex = 13;
			this.btnLocalizar.Text = "LOCALIZAR";
			this.btnLocalizar.UseVisualStyleBackColor = true;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.White;
			this.btnEditar.Location = new System.Drawing.Point(446, 63);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(122, 51);
			this.btnEditar.TabIndex = 14;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.Brown;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.Color.White;
			this.btnExcluir.Location = new System.Drawing.Point(446, 119);
			this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(122, 51);
			this.btnExcluir.TabIndex = 15;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.Red;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(446, 176);
			this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(122, 51);
			this.btnSair.TabIndex = 16;
			this.btnSair.Text = "SAIR";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(585, 402);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnLocalizar);
			this.Controls.Add(this.txtMatricula);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvFuncionario);
			this.Controls.Add(this.pbxAniversario);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.mskDataNascimento);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbxTurno);
			this.Controls.Add(this.btnInserir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO DE FUNCIONÁRIOS";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbxAniversario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ComboBox cbxTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox pbxAniversario;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
    }
}

