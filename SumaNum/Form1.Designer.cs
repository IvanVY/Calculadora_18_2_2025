﻿namespace SumaNum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            tbNum1 = new TextBox();
            tbNum2 = new TextBox();
            label3 = new Label();
            btnCalcular = new Button();
            result = new Label();
            sumar = new CheckBox();
            restar = new CheckBox();
            multiplicar = new CheckBox();
            dividir = new CheckBox();
            button1 = new Button();
            residuo = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 109);
            label1.Name = "label1";
            label1.Size = new Size(76, 14);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 186);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 1;
            label2.Text = "Número 2";
            // 
            // tbNum1
            // 
            tbNum1.Location = new Point(134, 144);
            tbNum1.Name = "tbNum1";
            tbNum1.Size = new Size(125, 22);
            tbNum1.TabIndex = 2;
            // 
            // tbNum2
            // 
            tbNum2.Location = new Point(134, 222);
            tbNum2.Name = "tbNum2";
            tbNum2.Size = new Size(125, 22);
            tbNum2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 41);
            label3.Name = "label3";
            label3.Size = new Size(157, 14);
            label3.TabIndex = 4;
            label3.Text = "Operaciones Básicas";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(46, 273);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 24);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(124, 397);
            result.Name = "result";
            result.Size = new Size(86, 14);
            result.TabIndex = 6;
            result.Text = "Resultado";
            // 
            // sumar
            // 
            sumar.AutoSize = true;
            sumar.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sumar.Location = new Point(33, 328);
            sumar.Name = "sumar";
            sumar.Size = new Size(38, 23);
            sumar.TabIndex = 7;
            sumar.Text = "+";
            sumar.UseVisualStyleBackColor = true;
            // 
            // restar
            // 
            restar.AutoSize = true;
            restar.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restar.Location = new Point(106, 328);
            restar.Name = "restar";
            restar.Size = new Size(38, 23);
            restar.TabIndex = 8;
            restar.Text = "-";
            restar.UseVisualStyleBackColor = true;
            // 
            // multiplicar
            // 
            multiplicar.AutoSize = true;
            multiplicar.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiplicar.Location = new Point(174, 328);
            multiplicar.Name = "multiplicar";
            multiplicar.Size = new Size(36, 23);
            multiplicar.TabIndex = 9;
            multiplicar.Text = "*";
            multiplicar.UseVisualStyleBackColor = true;
            // 
            // dividir
            // 
            dividir.AutoSize = true;
            dividir.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dividir.Location = new Point(234, 328);
            dividir.Name = "dividir";
            dividir.Size = new Size(35, 23);
            dividir.TabIndex = 10;
            dividir.Text = "/";
            dividir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(204, 274);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 11;
            button1.Text = "Ir Nueva Pantalla ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // residuo
            // 
            residuo.AutoSize = true;
            residuo.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            residuo.Location = new Point(296, 328);
            residuo.Name = "residuo";
            residuo.Size = new Size(44, 23);
            residuo.TabIndex = 12;
            residuo.Text = "%";
            residuo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(378, 513);
            Controls.Add(residuo);
            Controls.Add(button1);
            Controls.Add(dividir);
            Controls.Add(multiplicar);
            Controls.Add(restar);
            Controls.Add(sumar);
            Controls.Add(result);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(tbNum2);
            Controls.Add(tbNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Castellar", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Controles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNum1;
        private TextBox tbNum2;
        private Label label3;
        private Button btnCalcular;
        private Label result;
        private CheckBox sumar;
        private CheckBox restar;
        private CheckBox multiplicar;
        private CheckBox dividir;
        private Button button1;
        private CheckBox residuo;
    }
}
