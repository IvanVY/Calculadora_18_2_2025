using Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaNum
{
    public partial class Persona1 : Form
    {
        Crud crud = new Crud();

        public Persona1()
        {
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            //recupera nombre de usuario
            string nombre = cualquierNombre.Text;
            //recupera apellido de usuario
            string apellido = cualquierApellido.Text;
            //recupera edad del usucario
            int edad = int.Parse(cualquierEdad.Text);
            //recupera numero de telefono
            int telefono = int.Parse(cualquierTelefono.Text);
            //recupera correo electronico
            string correo = cualquierCorreo.Text;

            NombreClase p = new NombreClase(nombre, apellido, edad, telefono, correo);

            
            crud.agregarObjeto(p);
            MessageBox.Show("Usuario registrado con éxito");
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            
            foreach (var p in crud.lista)
            {
                MessageBox.Show("Nombre: " + p.nombre + "\nApellido: " + p.apellido + "\nEdad: " + p.edad + "\nTelefono: " + p.telefono + "\nCorreo: " + p.correo);
            }

            //Dos objetos de prueba
            //Darwin
            //Ivan
        }

    }
}
