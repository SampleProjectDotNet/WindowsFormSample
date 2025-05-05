using System;
using System.Windows.Forms;
using WindowsFormsApp.Service;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                double fahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);
                double kelvin = TemperatureConverter.CelsiusToKelvin(celsius);

                lblFahrenheit.Text = $"Fahrenheit: {fahrenheit:F2}";
                lblKelvin.Text = $"Kelvin: {kelvin:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido para Celsius.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
