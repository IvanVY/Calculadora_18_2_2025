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
            //falta validar que los campos no est�n vac�os y que sean num�ricos
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            
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
            }else if (restar.Checked)
            {
                mat.restar();
                MessageBox.Show("La resta es: " + mat.restar());
                result.Text = ("El resultado es: " + mat.restar().ToString());
            }else if(multiplicar.Checked){
                mat.multiplicar();
                MessageBox.Show("La multiplicaci�n es: " + mat.multiplicar());
                result.Text = ("El resultado es: " + mat.multiplicar().ToString());
            }else if (dividir.Checked)
            {
                mat.dividir();
                MessageBox.Show("La divisi�n es: " + mat.dividir());
                result.Text = ("El resultado es: " + mat.dividir().ToString());
            }
            return 0;
        }
    }
}
