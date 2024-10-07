using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace InsertInto
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=registros;Uid=root;Password='';";
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Coleta os dados do formul�rio
            string nome = txtNome.Text.Trim();
            string cpf = mskCPF.Text.Trim();
            string rg = mskRG.Text.Trim();
            string celular = mskCEL.Text.Trim();
            string dataNascimento = mskDataNascimento.Text.Trim();
            string ufNascimento = cmbUF.SelectedItem?.ToString(); // Coleta a UF

            string sexo = GetSexo();
            if (sexo == null)
            {
                MessageBox.Show("Selecione um sexo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida��o dos campos obrigat�rios
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(rg) ||
                string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(dataNascimento) || string.IsNullOrEmpty(ufNascimento))
            {
                MessageBox.Show("Todos os campos s�o obrigat�rios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida��o da data de nascimento
            if (!DateTime.TryParse(dataNascimento, out DateTime parsedDate))
            {
                MessageBox.Show("Data de nascimento inv�lida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conex�o com o banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO clientes (nome, cpf, rg, celular, dataNascimento, sexo, uf_nascimento) " +
                                   "VALUES (@Nome, @CPF, @RG, @Celular, @DataNascimento, @Sexo, @UFnascimento)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        cmd.Parameters.AddWithValue("@RG", rg);
                        cmd.Parameters.AddWithValue("@Celular", celular);
                        cmd.Parameters.AddWithValue("@DataNascimento", parsedDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Sexo", sexo);
                        cmd.Parameters.AddWithValue("@UFnascimento", ufNascimento); // Adiciona a UF

                        // Executa o comando
                        int result = cmd.ExecuteNonQuery();

                        // Verifica se o registro foi inserido com sucesso
                        if (result > 0)
                        {
                            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Falha ao cadastrar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetSexo()
        {
            if (rdbMasc.Checked)
                return "M";
            if (rdbFem.Checked)
                return "F";
            return null; // Nenhuma op��o selecionada
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            // Coleta o c�digo do cliente a ser exclu�do
            string codigoCliente = txtCodCliente.Text.Trim();

            // Valida��o do c�digo do cliente
            if (string.IsNullOrEmpty(codigoCliente))
            {
            MessageBox.Show("Por favor, informe o c�digo do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }

            // Conex�o com o banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM clientes WHERE Cliente = @Cliente";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cliente", codigoCliente);

                        // Executa o comando
                        int result = cmd.ExecuteNonQuery();

                        // Verifica se o registro foi exclu�do com sucesso
                        if (result > 0)
                        {
                            MessageBox.Show("Cliente exclu�do com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum cliente encontrado com esse c�digo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        
        private void btnExcluirTodos_Click(object sender, EventArgs e)
        {
            // Conex�o com o banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM clientes";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Executa o comando
                        int result = cmd.ExecuteNonQuery();

                        MessageBox.Show($"{result} cliente(s) exclu�do(s) com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
    }
}
    
