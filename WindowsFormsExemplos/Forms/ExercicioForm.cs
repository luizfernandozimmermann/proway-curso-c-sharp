using Newtonsoft.Json;
using ProWayModelos;
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
    public partial class ExercicioForm : Form
    {
        string caminhoArquivoJsonRegistrosDesktop = "";
        List<Registro> registros = new List<Registro>();

        public ExercicioForm()
        {
            caminhoArquivoJsonRegistrosDesktop =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                Path.DirectorySeparatorChar +
                "registros.json";
            InitializeComponent();
        }

        private void linkLabelRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelRegistrar.Text == "Registrar")
            {
                ResetarCampos();
            }
            else
            {
                linkLabelRegistrar.Text = "Registrar";
                buttonEntrar.Text = "Entrar";
            }
        }

        private void ResetarCampos()
        {
            linkLabelRegistrar.Text = "Já possuo conta";
            buttonEntrar.Text = "Registrar";
            textBoxUsuário.Text = "";
            textBoxSenha.Text = "";
            textBoxCorFav.Text = "";
        }

        private void ExercicioForm_Load(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void CarregarRegistros()
        {
            if (File.Exists(caminhoArquivoJsonRegistrosDesktop) == false)
            {
                return;
            }

            var arquivoLinhas = File.ReadAllText(caminhoArquivoJsonRegistrosDesktop);
            var registrosCarregados = JsonConvert.DeserializeObject<List<Registro>>(arquivoLinhas);

            if (registrosCarregados != null)
            {
                registros = registrosCarregados;
            }
        }

        private void SalvarRegistros()
        {
            var registrosSerializados = JsonConvert.SerializeObject(registros);

            File.WriteAllText(caminhoArquivoJsonRegistrosDesktop, registrosSerializados);
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            var usuario = textBoxUsuário.Text;

            if (usuario.Length < 3)
            {
                MessageBox.Show("Usuário inválido.");
                return;
            }

            var senha = textBoxSenha.Text;

            if (senha == "")
            {
                MessageBox.Show("Digite a senha.");
                return;
            }

            var corFav = textBoxCorFav.Text;
            if (corFav == "")
            {
                MessageBox.Show("Digite a cor favorita.");
                return;
            }

            var registro = new Registro();
            registro.Usuario = usuario;
            registro.Senha = senha;
            registro.CorFav = corFav;

            if (buttonEntrar.Text == "Entrar")
            {
                for (int i = 0; i < registros.Count; i++)
                {
                    var registroLista = registros[i];
                    if (registroLista.Usuario == registro.Usuario &&
                        registroLista.Senha == registro.Senha &&
                        registroLista.CorFav == registro.CorFav)
                    {
                        MessageBox.Show("Entrou!");
                        return;
                    }
                }
                MessageBox.Show("Usuário, senha ou Cor favorita errados.");
                
            }
            else
            {
                for (int i = 0;i < registros.Count;i++)
                {
                    if (registros[i].Usuario == registro.Usuario)
                    {
                        MessageBox.Show("Usuário já existe");
                        return;
                    }
                }
                registros.Add(registro);
                SalvarRegistros();
                ResetarCampos();
            }
        }
    }
}
