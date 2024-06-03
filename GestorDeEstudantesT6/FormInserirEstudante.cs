using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            // exibe uma janela para procurar a imagem.
            OpenFileDialog selecionarImagem = new OpenFileDialog();

            selecionarImagem.Filter = "Selecione a foto (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
        
            selecionarImagem.ShowDialog();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
