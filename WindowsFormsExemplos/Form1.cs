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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nome = textboxNome.Text;
            int quantidadeHoras = 0;
            try
            {
                quantidadeHoras = Convert.ToInt32(textboxQuantidadeHoras.Text);
                textboxQuantidadeHoras.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quantidade de horas deve conter apenas números.");
                textboxQuantidadeHoras.Focus();
                textboxQuantidadeHoras.ForeColor = Color.Red;
                return;
            }

            double valorHora = 0;
            try
            {
                valorHora = Convert.ToDouble(textboxValorHora.Text);
                textboxValorHora.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor hora deve conter apenas números reais.");
                textboxValorHora.Focus();
                textboxValorHora.ForeColor = Color.Red;
                return;
            }

            FolhaPagamento folhaPagamento = new FolhaPagamento();
            folhaPagamento.NomeColaborador = nome;
            folhaPagamento.ValorHora = valorHora;
            folhaPagamento.QuantidadeHoras = quantidadeHoras;

            MessageBox.Show($@"Folha de pagamento: {folhaPagamento.NomeColaborador}
Salário bruto: {folhaPagamento.CalcularSalarioBruto():C}
Desconto INSS: {folhaPagamento.CalcularInss():C}");

            var jsonFolhaPagamento = JsonConvert.SerializeObject(folhaPagamento);
            File.WriteAllText("C:\\Users\\73672\\Desktop\\cursos-c#\\proway-curso-c-sharp-fundamentos\\arquivo.json", jsonFolhaPagamento);
        }

        private void button1_Move(object sender, EventArgs e)
        {

        }
    }
}