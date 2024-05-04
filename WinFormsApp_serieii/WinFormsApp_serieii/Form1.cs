namespace WinFormsApp_serieii
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            int MontoInicial = int.Parse(textBox_Monto.Text);
            int TasaInteres = int.Parse(textBox_Interes.Text);
            int Plazo = int.Parse(textBox_Plazo.Text);
            int CuotaMensual = MontoInicial*TasaInteres / (int)(1 - Math.Pow(1 + TasaInteres, -Plazo));
            int Capital = (CuotaMensual) + (TasaInteres);
            MessageBox.Show($"La cuota mensual es de: {CuotaMensual},el total de intereses a pagar es de {TasaInteres} y el total de capital a pagar es de {Capital} ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
