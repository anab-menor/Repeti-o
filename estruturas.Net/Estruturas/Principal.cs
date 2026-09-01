namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        bool mostrarRespostas = false;
        bool validarSenhas = false;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "Tente123@";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            string site = "https://pixabay.com/pt/videos/search/gatinhos/";

            while (site != "")
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = site,
                    UseShellExecute = true
                });

                site = "";
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int num = 1;
            lsbMostra.Items.Clear();

            do
            {
                if (num == 1)
                    lsbMostra.Items.Add("Oii sor oscar, seja bem-vindo!");
                else if (num == 2)
                    lsbMostra.Items.Add("Td bemmmmm?!");
                else if (num == 3)
                    lsbMostra.Items.Add("Que vc possa ter um ótimo dayyyy!");
                else if (num == 4)
                    lsbMostra.Items.Add("QUEREMOS PATE!");
                else
                    lsbMostra.Items.Add("Tchauzinhoooo!");

                num++;
            }
            while (num <= 5);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            string[] sites =
            {
                "https://www.microsoft.com/pt-br/microsoft-teams/log-in",
                "https://nsaetec.com.br/",
                "https://www.cps.sp.gov.br"
            };

            for (int i = 0; i < sites.Length; i++)
            {
                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = sites[i],
                        UseShellExecute = true
                    });
            }
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            string[] perguntas =
            {
                "1. 🌍 Qual é o maior planeta?",
                "2. 🐋 Qual é o maior animal do mundo?",
                "3. 💧 Qual é a fórmula da água?",
                "4. 🌎 Quantos continentes existem?"
            };
            

            string[] respostas =
           {
                "1. 🌍 Júpiter",
                "2. 🐋 Baleia-azul",
                "3. 💧 H2O",
                "4. 🌎 6 continentes"
           };

            lsbMostra.Items.Clear();

            if (mostrarRespostas == false)
            {
                foreach (string pergunta in perguntas)
                {
                    lsbMostra.Items.Add(pergunta);
                }

                lsbMostra.Items.Add("");
                lsbMostra.Items.Add("Aperte novamente o botão ForEach para aparecer suas respostas!!");

                mostrarRespostas = true;
            }
            else
            {
                foreach (string resposta in respostas)
                {
                    lsbMostra.Items.Add(resposta);
                }

                lsbMostra.Items.Add("");
                lsbMostra.Items.Add("🎯 Quantas você acertou?");

                mostrarRespostas = false;
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            double valor = 200;
            int porcentagem = 10;

            lsbMostra.Items.Clear();

            while (porcentagem <= 100)
            {
                double resultado = valor * porcentagem / 100;

                lsbMostra.Items.Add(
                    porcentagem + "% de " + valor + " = " + resultado
                );

                if (porcentagem == 50)
                {
                    lsbMostra.Items.Add("");
                    lsbMostra.Items.Add("Cálculo interrompido em 50%.");
                    break;
                }

                porcentagem += 10;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string[] senhas =
{
    "123",
    "abc12",
    "Senha123",
    "programacao",
    "Ana2026",
    "12345678"
};

            lsbMostra.Items.Clear();

            if (validarSenhas == false)
            {
                lsbMostra.Items.Add("🔐 VALIDAÇÃO DE SENHAS");
                lsbMostra.Items.Add("");

                foreach (string senha in senhas)
                {
                    lsbMostra.Items.Add("Senha: " + senha);
                }

                lsbMostra.Items.Add("");
                lsbMostra.Items.Add("Aperte novamente o botão Continue para validar as senhas.");

                validarSenhas = true;
            }
            else
            {
                lsbMostra.Items.Add("🔐 VALIDAÇÃO DE SENHAS");
                lsbMostra.Items.Add("");

                foreach (string senha in senhas)
                {
                    if (senha.Length < 6 || !senha.Any(char.IsDigit))
                    {
                        lsbMostra.Items.Add("❌ " + senha + " - inválida");
                        continue;
                    }

                    lsbMostra.Items.Add("✅ " + senha + " - válida");
                }

                lsbMostra.Items.Add("");
                lsbMostra.Items.Add("🔎 Verificação concluída!");

                validarSenhas = false;
            }
        }
         
    }
}
