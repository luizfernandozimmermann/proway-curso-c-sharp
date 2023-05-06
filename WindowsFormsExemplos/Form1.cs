using Newtonsoft.Json;

namespace WindowsFormsExemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textboxNome.Text;
            int quantidadeHoras = Convert.ToInt32(textboxQuantidadeHoras.Text);
            double valorHora = Convert.ToDouble(textboxValorHora.Text);

            FolhaPagamento folhaPagamento = new FolhaPagamento();
            folhaPagamento.NomeColaborador = nome;
            folhaPagamento.ValorHora = valorHora;
            folhaPagamento.QuantidadeHoras = quantidadeHoras;

            MessageBox.Show($@"Folha de pagamento: {folhaPagamento.NomeColaborador}
Salário bruto: {folhaPagamento.CalcularSalarioBruto():C}
Desconto INSS: {folhaPagamento.CalcularInss():C}");

            var jsonFolhaPagamento = JsonConvert.SerializeObject(folhaPagamento);
            File.WriteAllText("C:\\Users\\Luiz Fernando\\Desktop\\programacao\\C#\\proway\\arquivo.json", jsonFolhaPagamento);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}