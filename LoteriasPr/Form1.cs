using LoteriasPr.Models;
using LoteriasPr.Services;
using static System.Net.Mime.MediaTypeNames;

namespace LoteriasPr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            var menorNumero = 1;
            var maiorNumero = Convert.ToInt32(nupMax.Value);
            var sorteados = Convert.ToInt32(nupSorteados.Value);
            var apostados = Convert.ToInt32(nupApostados.Value);
            if (menorNumero < 1 || maiorNumero < 2 || sorteados < 1 || apostados < 1)
            {
                txtResult.Text = "Error! Check the inputs!";
                return;
            }
            if (menorNumero >= maiorNumero || apostados < sorteados || sorteados > apostados)
            {
                txtResult.Text = "Error! Check the inputs!";
                return;
            }
            var aposta = new Aposta(menorNumero, maiorNumero, sorteados, apostados);
            var calculadora = new CalculadoraService();
            string text = string.Empty;
            try
            {
                var chances = calculadora.CalcularProbabilidade(aposta);
                text = $"\nChance de acertar {sorteados} números: 1 em {chances:N0} ! \nTotal de números apostados: {apostados}.";
                txtResult.Text = text;
            }
            catch (ArgumentException ex)
            {
                text = $"Erro: {ex.Message}";
                MessageBox.Show(text, "Resultado", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            nupMax.Value = 2;
            nupSorteados.Value = 1;
            nupApostados.Value = 1;
            txtResult.Text = string.Empty;
        }
    }
}
