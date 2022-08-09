namespace ControlAyV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de salir?", "Medidas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes);
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Calculando los valores
            double altura = double.Parse(txtAltura.Text);
            double diametro = double.Parse(txtDiametro.Text);

            //Reaizando los calculos
            double radio = diametro / 2;
            double area = (2 * Math.PI * radio) * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            //Mostrando resultados
            txtR.Text = "** RESUMEN DE VOLUMEN Y AREAS **";
            txtR.Text += "\r\nValor Altura: " + altura.ToString("0.00");
            txtR.Text += "\r\nValor Diametro: " + diametro.ToString("0.00");
            txtR.Text += "\r\n---------------------------------------------";
            txtR.Text += "\r\nRadio: " + radio.ToString("0.00");
            txtR.Text += "\r\nArea: " + area.ToString("0.00");
            txtR.Text += "\r\nVolumen: " + volumen.ToString("0.00");









        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtDiametro.Clear();
            txtR.Clear();
            txtAltura.Focus();
        }
    }
}