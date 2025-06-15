using LoteriasPr.Models;
using LoteriasPr.Services;

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
            
            int min = 1;            
            int max = 60;            
            int sorteados = 6;            
            int apostados = 7;
            ///TODO - DO THE INPUTS TO THE VARS ABOVE CANNOT BE CONSTANTS LIKE THAT.
            var aposta = new Aposta(min, max, sorteados, apostados);
            var calculadora = new CalculadoraService();
            string texto = string.Empty;
            try
            {
                var chances = calculadora.CalcularProbabilidade(aposta);
                texto= $"\nChance de acertar {sorteados} números: 1 em {chances:N0}.\nTotal de números apostados: {apostados}.";
                MessageBox.Show(texto);
            }
            catch (ArgumentException ex)
            {
                texto= $"Erro: {ex.Message}";
                MessageBox.Show(texto,"Resultado",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign,true);
            }
        }
    }
}
