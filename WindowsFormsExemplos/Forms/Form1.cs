using Newtonsoft.Json;
using ProWayModelos;

namespace WindowsFormsExemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            int quantidadeHoras = 0;
            try
            {
                quantidadeHoras = Convert.ToInt32(textBoxQuantidadeHoras.Text);
                textBoxQuantidadeHoras.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quantidade de horas deve conter somente números");
                textBoxQuantidadeHoras.Focus();
                textBoxQuantidadeHoras.ForeColor = Color.Red;
                return;
            }

            double valorHora = 0;
            try
            {
                valorHora = Convert.ToDouble(textBoxValorHora.Text);
                textBoxValorHora.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor hora deve conter somente valor real");
                textBoxValorHora.Focus();
                textBoxValorHora.ForeColor = Color.Red;
                return;
            }

            FolhaPagamento folhaPagamento = new FolhaPagamento();
            folhaPagamento.NomeColaborador = nome;
            folhaPagamento.QuantidadeHoras = quantidadeHoras;
            folhaPagamento.ValorHora = valorHora;

            MessageBox.Show($@"Folha de Pagamento: {folhaPagamento.NomeColaborador}
Salário Bruto: {folhaPagamento.CalcularSalarioBruto():C}
Desconto INSS: {folhaPagamento.CalcularInss():C}");

            string jsonFolhaPagamento = JsonConvert.SerializeObject(folhaPagamento);
            File.WriteAllText("C:\\Users\\Moc\\Desktop\\Arquivo.json", jsonFolhaPagamento);

        }
    }
}