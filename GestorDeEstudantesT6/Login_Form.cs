using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantesT6
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

            MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter();
            DataTable minhaTabela = new DataTable();
            MySqlCommand meuComandoSql = new MySqlCommand("", meuBancoDeDados.getConexao);
        }
    }
}
