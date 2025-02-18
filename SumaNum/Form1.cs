namespace SumaNum
{
    public partial class Form1 : Form
    {
        Matematica mat;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNum1.Text) || string.IsNullOrWhiteSpace(tbNum2.Text))
            {
                MessageBox.Show("Por favor, ingrese valores en ambos campos.");
                return;
            }

            if (!int.TryParse(tbNum1.Text, out int num1) || !int.TryParse(tbNum2.Text, out int num2))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
                return;
            }

            mat = new Matematica(num1, num2);
            calcularOperacion();
        }
        private int calcularOperacion()
        {
            if (sumar.Checked)
            {
                mat.sumar();
                MessageBox.Show("La súma es: " + mat.sumar());
                result.Text = ("El resultado es: " + mat.sumar().ToString());
            }
            else if (restar.Checked)
            {
                mat.restar();
                MessageBox.Show("La resta es: " + mat.restar());
                result.Text = ("El resultado es: " + mat.restar().ToString());
            }
            else if (multiplicar.Checked)
            {
                mat.multiplicar();
                MessageBox.Show("La multiplicación es: " + mat.multiplicar());
                result.Text = ("El resultado es: " + mat.multiplicar().ToString());
            }
            else if (dividir.Checked)
            {
                mat.dividir();
                MessageBox.Show("La división es: " + mat.dividir());
                result.Text = ("El resultado es: " + mat.dividir().ToString());
            }
            return 0;
        }
    }
}
