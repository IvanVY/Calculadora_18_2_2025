namespace SumaNum
{
    partial class Persona1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cualquierNombre1 = new Label();
            cualquierApellido2 = new Label();
            cualquierEdad2 = new Label();
            cualquierTelefono2 = new Label();
            cualquierNombre = new TextBox();
            cualquierApellido = new TextBox();
            cualquierEdad = new TextBox();
            cualquierTelefono = new TextBox();
            cualquierCorreo = new TextBox();
            registrar = new Button();
            btnMostrarLista = new Button();
            cualquierCorreo2 = new Label();
            SuspendLayout();
            // 
            // cualquierNombre1
            // 
            cualquierNombre1.AutoSize = true;
            cualquierNombre1.Location = new Point(103, 59);
            cualquierNombre1.Name = "cualquierNombre1";
            cualquierNombre1.Size = new Size(105, 15);
            cualquierNombre1.TabIndex = 0;
            cualquierNombre1.Text = "Ingrese su nombre";
            // 
            // cualquierApellido2
            // 
            cualquierApellido2.AutoSize = true;
            cualquierApellido2.Location = new Point(103, 103);
            cualquierApellido2.Name = "cualquierApellido2";
            cualquierApellido2.Size = new Size(105, 15);
            cualquierApellido2.TabIndex = 1;
            cualquierApellido2.Text = "Ingrese su apellido";
            // 
            // cualquierEdad2
            // 
            cualquierEdad2.AutoSize = true;
            cualquierEdad2.Location = new Point(103, 147);
            cualquierEdad2.Name = "cualquierEdad2";
            cualquierEdad2.Size = new Size(89, 15);
            cualquierEdad2.TabIndex = 2;
            cualquierEdad2.Text = "Ingrese su edad";
            // 
            // cualquierTelefono2
            // 
            cualquierTelefono2.AutoSize = true;
            cualquierTelefono2.Location = new Point(103, 191);
            cualquierTelefono2.Name = "cualquierTelefono2";
            cualquierTelefono2.Size = new Size(168, 15);
            cualquierTelefono2.TabIndex = 3;
            cualquierTelefono2.Text = "Ingrese su número de telefono";
            // 
            // cualquierNombre
            // 
            cualquierNombre.Location = new Point(103, 77);
            cualquierNombre.Name = "cualquierNombre";
            cualquierNombre.Size = new Size(100, 23);
            cualquierNombre.TabIndex = 5;
            // 
            // cualquierApellido
            // 
            cualquierApellido.Location = new Point(103, 121);
            cualquierApellido.Name = "cualquierApellido";
            cualquierApellido.Size = new Size(100, 23);
            cualquierApellido.TabIndex = 6;
            // 
            // cualquierEdad
            // 
            cualquierEdad.Location = new Point(103, 165);
            cualquierEdad.Name = "cualquierEdad";
            cualquierEdad.Size = new Size(100, 23);
            cualquierEdad.TabIndex = 7;
            // 
            // cualquierTelefono
            // 
            cualquierTelefono.Location = new Point(103, 209);
            cualquierTelefono.Name = "cualquierTelefono";
            cualquierTelefono.Size = new Size(100, 23);
            cualquierTelefono.TabIndex = 8;
            // 
            // cualquierCorreo
            // 
            cualquierCorreo.Location = new Point(103, 253);
            cualquierCorreo.Name = "cualquierCorreo";
            cualquierCorreo.Size = new Size(100, 23);
            cualquierCorreo.TabIndex = 9;
            // 
            // registrar
            // 
            registrar.Location = new Point(117, 295);
            registrar.Name = "registrar";
            registrar.Size = new Size(75, 23);
            registrar.TabIndex = 10;
            registrar.Text = "Registrar";
            registrar.UseVisualStyleBackColor = true;
            registrar.Click += registrar_Click;
            // 
            // btnMostrarLista
            // 
            btnMostrarLista.Location = new Point(112, 340);
            btnMostrarLista.Name = "btnMostrarLista";
            btnMostrarLista.Size = new Size(91, 23);
            btnMostrarLista.TabIndex = 11;
            btnMostrarLista.Text = "Mostrar lista";
            btnMostrarLista.UseVisualStyleBackColor = true;
            btnMostrarLista.Click += btnMostrarLista_Click;
            // 
            // cualquierCorreo2
            // 
            cualquierCorreo2.AutoSize = true;
            cualquierCorreo2.Location = new Point(103, 235);
            cualquierCorreo2.Name = "cualquierCorreo2";
            cualquierCorreo2.Size = new Size(159, 15);
            cualquierCorreo2.TabIndex = 12;
            cualquierCorreo2.Text = "Ingrese su correo electronico";
            // 
            // Persona1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 455);
            Controls.Add(cualquierCorreo2);
            Controls.Add(btnMostrarLista);
            Controls.Add(registrar);
            Controls.Add(cualquierCorreo);
            Controls.Add(cualquierTelefono);
            Controls.Add(cualquierEdad);
            Controls.Add(cualquierApellido);
            Controls.Add(cualquierNombre);
            Controls.Add(cualquierTelefono2);
            Controls.Add(cualquierEdad2);
            Controls.Add(cualquierApellido2);
            Controls.Add(cualquierNombre1);
            Name = "Persona1";
            Text = "Persona1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cualquierNombre1;
        private Label cualquierApellido2;
        private Label cualquierEdad2;
        private Label cualquierTelefono2;
        private TextBox cualquierNombre;
        private TextBox cualquierApellido;
        private TextBox cualquierEdad;
        private TextBox cualquierTelefono;
        private TextBox cualquierCorreo;
        private Button registrar;
        private Button btnMostrarLista;
        private Label cualquierCorreo2;
    }
}