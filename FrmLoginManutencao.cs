using System;
using System.IO;
using System.Windows.Forms;

namespace SupervisorioDana
{
    public partial class FrmLoginManutencao : Form
    {
        public string UsuarioConfirmado { get; private set; } = null;

        public FrmLoginManutencao()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userscontrol.txt");
            if (!File.Exists(caminho))
            {
                MessageBox.Show("Arquivo de usuários não encontrado.");
                return;
            }

            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            string[] linhas = File.ReadAllLines(caminho);
            for (int i = 0; i + 2 < linhas.Length; i += 3)
            {
                string nome = linhas[i];
                string pass = linhas[i + 1];
                string nivel = linhas[i + 2];

                if (nome == login && pass == senha)
                {
                    if (nivel == "3")
                    {
                        UsuarioConfirmado = nome;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Somente usuários de nível 3 podem confirmar a manutenção.",
                                        "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            MessageBox.Show("Usuário ou senha incorretos.",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
