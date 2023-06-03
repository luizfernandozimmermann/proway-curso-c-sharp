using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExemplos.Forms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonFolhaPagamento_Click(object sender, EventArgs e)
        {
            Form1 folhaPagamentoForm = new Form1();
            folhaPagamentoForm.ShowDialog();
        }

        private void buttonCadastroSimplificadoProduto_Click(object sender, EventArgs e)
        {
            ProdutoCadastroSimplificadoForm form = new ProdutoCadastroSimplificadoForm();
            form.ShowDialog();
        }

        private void buttonCadastroFilmes_Click(object sender, EventArgs e)
        {
            FilmeCadastroForm form = new FilmeCadastroForm();
            form.ShowDialog();
        }

        private void buttonExercicio_Click(object sender, EventArgs e)
        {
            ExercicioForm form = new ExercicioForm();
            form.ShowDialog();
        }

        private void buttonFormBancoDados_Click(object sender, EventArgs e)
        {
            var form = new ProdutoCadastroSimplificadoBancoDadosForm();
            form.ShowDialog();
        }
    }
}
