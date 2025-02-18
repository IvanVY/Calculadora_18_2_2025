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
            //falta validar que los campos no estén vacíos y que sean numéricos
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
                MessageBox.Show("La súma es: " + mat.sumar());
                result.Text = ("El resultado es: " + mat.sumar().ToString());
            }else if (restar.Checked)
            {
                mat.restar();
                MessageBox.Show("La resta es: " + mat.restar());
                result.Text = ("El resultado es: " + mat.restar().ToString());
            }else if(multiplicar.Checked){
                mat.multiplicar();
                MessageBox.Show("La multiplicación es: " + mat.multiplicar());
                result.Text = ("El resultado es: " + mat.multiplicar().ToString());
            }else if (dividir.Checked)
            {
                mat.dividir();
                MessageBox.Show("La división es: " + mat.dividir());
                result.Text = ("El resultado es: " + mat.dividir().ToString());
            }
            return 0;
        }
    }
}
