using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroFuncionariosGcm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var matricula = txtMatricula.Text;
            var graduacao = txtGraduacao.Text;
            var quantidade = txtQtd.Text;
            var nomeDeGuerra = txtNomeGuerra.Text;
            var nome = txtNome.Text;
            var ativo = (rdioSim.Checked) ? 1 : 0;
            try
            {
                string strCnx = "Server=osas;Initial Catalog=DB_CadastroFunc;user id=sa;pwd=x";
                string strCmm = "INSERT INTO Cadastro(matricula, graduacao, nome_de_guerra, nome_completo, quantidade, ativo) "
                               + $" values('{matricula}', '{graduacao}', '{nomeDeGuerra}', '{nome}', '{quantidade}', '{ativo}')";

                var conn = new SqlConnection(strCnx);
                conn.Open();
                var comm = new SqlCommand(strCmm, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cadastro Efetuado!");
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }
    }
}
