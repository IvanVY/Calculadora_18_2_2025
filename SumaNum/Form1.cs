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
                MessageBox.Show("Por favor, ingrese valores num�ricos v�lidos.");
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
                MessageBox.Show("La s�ma es: " + mat.sumar());
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
                MessageBox.Show("La multiplicaci�n es: " + mat.multiplicar());
                result.Text = ("El resultado es: " + mat.multiplicar().ToString());
            }
            else if (dividir.Checked)
            {
                mat.dividir();
                MessageBox.Show("La divisi�n es: " + mat.dividir());
                result.Text = ("El resultado es: " + mat.dividir().ToString());
            }
            else if (residuo.Checked)
            {
                mat.dividir();
                MessageBox.Show("El residuo es: " + mat.residuo());
                result.Text = ("El resultado es: " + mat.residuo().ToString());
            }
                return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona1 p = new Persona1();
            p.Show();
        }

    }
}
