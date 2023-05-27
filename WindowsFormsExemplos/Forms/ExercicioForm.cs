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
                linkLabelRegistrar.Text = "Já possuo conta";
            }
            else
            {
                linkLabelRegistrar.Text = "Registrar";
            }
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
    }
}
