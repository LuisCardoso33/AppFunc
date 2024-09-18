using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFunc
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Funcionario funcionario = new Funcionario();
            string data = DateTime.Now.ToString("dd/MM/yyyy");
            if (funcionario.Aniversariantes(data) == false)
            {
                pbxAniversario.Visible = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            List<Funcionario> func = funcionario.listafuncionario();
            dgvFuncionario.DataSource = func;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtMatricula.Text == "" || cbxTurno.Text == "" || mskDataNascimento.Text == "")
            {
                MessageBox.Show("Por, favor, preencha todos os campos!");
                return;
            }
            try
            {
                Funcionario funcionario = new Funcionario();
                if (funcionario.RegistroRepetido(txtMatricula.Text) == true)
                {
                    MessageBox.Show("Funcionário já existe em nossa base de dados!");
                    txtNome.Text = string.Empty;
                    txtMatricula.Text = string.Empty;
                    cbxTurno.Text = string.Empty;
                    mskDataNascimento.Text = string.Empty;
                    this.ActiveControl = txtNome;
                }
                else
                {
                    funcionario.Inserir(txtNome.Text, cbxTurno.Text, mskDataNascimento.Text, txtMatricula.Text);
                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                    List<Funcionario> func = funcionario.listafuncionario();
                    dgvFuncionario.DataSource = func;
                    txtNome.Text = string.Empty;
                    txtMatricula.Text = string.Empty;
                    cbxTurno.Text = string.Empty;
                    mskDataNascimento.Text = string.Empty;
                    this.ActiveControl  = txtNome;
                    string data = DateTime.Now.ToString("dd/MM/yyyy");
                    if (funcionario.Aniversariantes(data) == false)
                    {
                        pbxAniversario.Visible = false;
                    }
                    else
                    {
                        pbxAniversario.Visible = true;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Por favor, digite um ID válido!");
                this.ActiveControl = txtId;
                return;
            }
            try
            {
                Funcionario funcionario = new Funcionario();
                int Id = Convert.ToInt32(txtId.Text.Trim());
                if (funcionario.ExisteId(Id) == false)
                {
                    MessageBox.Show("ID inexistente! Por favor, tente novamente!");
                    this.ActiveControl = txtId;
                    return;
                }
                else
                {
                    funcionario.Localiza(Id);
                    txtNome.Text = funcionario.nome;
                    cbxTurno.Text = funcionario.turno;
                    mskDataNascimento.Text = funcionario.data_nascimento;
                    txtMatricula.Text = funcionario.matricula;
                    if (txtNome.Text != null)
                    {
                        btnEditar.Enabled = true;
                        btnExcluir.Enabled = true;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.Atualizar(Id, txtNome.Text, cbxTurno.Text, mskDataNascimento.Text, txtMatricula.Text);
                MessageBox.Show("Funcionário atualizado com sucesso!");
                List<Funcionario> func = funcionario.listafuncionario();
                dgvFuncionario.DataSource = func;
                txtId.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtMatricula.Text = string.Empty;
                cbxTurno.Text = string.Empty;
                mskDataNascimento.Text = string.Empty;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                string data = DateTime.Now.ToString("dd/MM/yyyy");
                if (funcionario.Aniversariantes(data) == false)
                {
                    pbxAniversario.Visible = false;
                }
                else
                {
                    pbxAniversario.Visible = true;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text.Trim());
            Funcionario funcionario = new Funcionario();
            var a = MessageBox.Show("Deseja realmente excluir este funcionário?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                funcionario.Excluir(Id);
                MessageBox.Show("Funcionário excluído com sucesso!");
                List<Funcionario> func = funcionario.listafuncionario();
                dgvFuncionario.DataSource = func;
                txtId.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtMatricula.Text = string.Empty;
                cbxTurno.Text = string.Empty;
                mskDataNascimento.Text = string.Empty;
                this.ActiveControl = txtNome;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            string data = DateTime.Now.ToString("dd/MM/yyyy");
            if (funcionario.Aniversariantes(data) == false)
            {
                pbxAniversario.Visible = false;
            }
            else
            {
                pbxAniversario.Visible = true;
            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFuncionario.Rows[e.RowIndex];
                this.dgvFuncionario.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                cbxTurno.Text = row.Cells[2].Value.ToString();
                mskDataNascimento.Text = row.Cells[3].Value.ToString();
                txtMatricula.Text = row.Cells[4].Value.ToString();
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

		private void pbxAniversario_Click(object sender, EventArgs e)
		{
            frmAniversario aniversario = new frmAniversario();
            aniversario.Show();
		}
	}
}
