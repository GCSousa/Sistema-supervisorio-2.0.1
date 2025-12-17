using System;
using System.IO;
using System.Windows.Forms;

namespace SupervisorioDana
{
    public partial class FrmVisualizarNotas : Form
    {
        public FrmVisualizarNotas()
        {
            InitializeComponent();
            CarregarNotas();
        }

        private void CarregarNotas()
        {
            try
            {
                // Define o caminho para o ficheiro de notas
                string caminho = Environment.CurrentDirectory;
                //
                string caminhoArquivoNotas = Path.Combine(caminho, "notas_manutencao_geral.txt");

                if (File.Exists(caminhoArquivoNotas))
                {
                    // Lê todo o ficheiro de log
                    string conteudo = File.ReadAllText(caminhoArquivoNotas);
                    this.txtNotas.Text = conteudo;
                }
                else
                {
                    this.txtNotas.Text = "Arquivo 'notas_manutencao_geral.txt' não encontrado.";
                }
            }
            catch (Exception ex)
            {
                this.txtNotas.Text = "Erro ao ler o arquivo de notas: \r\n" + ex.Message;
            }
        }
    }
}