using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
namespace BDcomC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(CriarConexao());
                conexao.Open();
                MessageBox.Show("Conectado...", "Conexão com o banco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar entrar no Banco de Dados", "Error" + ex.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(CriarConexao());
                conexao.Close();
                MessageBox.Show("Desconectado...", "Desconectando do banco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar sair do Banco de Dados", "Error" + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string database = txtDB.Text;
            string userID = txtUserID.Text;
            string password = txtSenha.Text;

            txtString.Text = ($"Server = {server}, DB = {database}, User ID = {userID}, Password = {password}");
        }
        private string CriarConexao()
        {
            string server = txtServer.Text;
            string database = txtDB.Text;
            string userId = txtUserID.Text;
            string password = txtSenha.Text;

            return $"Server={server};Database={database};User ID={userId};Password={password};";
        }
    }
}