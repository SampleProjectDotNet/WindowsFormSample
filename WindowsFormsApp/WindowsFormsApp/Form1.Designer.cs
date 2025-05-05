using System.Windows.Forms;
using System;
using WindowsFormsApp.Service;

namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(12, 12);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(118, 10);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(12, 45);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(64, 13);
            this.lblFahrenheit.TabIndex = 2;
            this.lblFahrenheit.Text = "Fahrenheit: ";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(12, 68);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(42, 13);
            this.lblKelvin.TabIndex = 3;
            this.lblKelvin.Text = "Kelvin: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtCelsius);
            this.Name = "Form1";
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblKelvin;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Verifica se o valor inserido no campo txtCelsius é válido
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                // Realiza as conversões
                var converter = new TemperatureConverter();
                double fahrenheit = converter.CelsiusToFahrenheit(celsius);
                double kelvin = converter.CelsiusToKelvin(celsius);

                // Atualiza os labels com os resultados
                lblFahrenheit.Text = $"Fahrenheit: {fahrenheit:F2}";
                lblKelvin.Text = $"Kelvin: {kelvin:F2}";
            }
            else
            {
                // Exibe uma mensagem de erro caso o valor seja inválido
                MessageBox.Show("Por favor, insira um valor válido para Celsius.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}