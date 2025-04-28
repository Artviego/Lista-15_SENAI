namespace Lista_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarDataGrid();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtId.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    Setor setor = new Setor();
                    setor.Id = txtId.Text;
                    setor.Nome = txtNome.Text;

                    if (setor.InserirSetor())
                    {
                        MessageBox.Show("Setor " + txtNome.Text + " cadastrado com sucesso!", "Sucesso - cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Clear();
                        txtNome.Clear();
                        AtualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher os campos", "Erro - campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar o cadastro: " + ex.Message, "Erro - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtId.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    Setor setor = new Setor();
                    setor.Id = txtId.Text;
                    setor.Nome = txtNome.Text;

                    if (setor.AtualizarSetor())
                    {
                        MessageBox.Show("Setor " + txtId.Text + " atualizado com sucesso!", "Sucesso - Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Clear();
                        txtNome.Clear();
                        AtualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher os campos", "Erro - campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a edição: " + ex.Message, "Erro - Edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtId.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    Setor setor = new Setor();
                    setor.Id = txtId.Text;
                    setor.Nome = txtNome.Text;

                    if (setor.ExcluirSetor())
                    {
                        MessageBox.Show("Setor " + txtId.Text + " excluído com sucesso!", "Sucesso - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Clear();
                        txtNome.Clear();
                        AtualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher os campos", "Erro - campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a edição: " + ex.Message, "Erro - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarDataGrid()
        {
            dtgSetores.DataSource = Setor.ListarSetores();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = txtPesquisar.Text;
            dtgSetores.DataSource = Setor.ListarSetorPorNome(nome);
        }
    }
}