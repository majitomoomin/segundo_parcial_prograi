namespace WinFormsApp_serieii
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
            label_monto = new Label();
            label_interes = new Label();
            label_prestamo = new Label();
            label_Total = new Label();
            textBox_Monto = new TextBox();
            textBox_Interes = new TextBox();
            textBox_Plazo = new TextBox();
            button_Calcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F);
            label1.Location = new Point(271, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(396, 31);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de cuotas de prestamo";
            label1.Click += label1_Click;
            // 
            // label_monto
            // 
            label_monto.AutoSize = true;
            label_monto.Font = new Font("Times New Roman", 14F);
            label_monto.Location = new Point(331, 111);
            label_monto.Margin = new Padding(4, 0, 4, 0);
            label_monto.Name = "label_monto";
            label_monto.Size = new Size(301, 27);
            label_monto.TabIndex = 1;
            label_monto.Text = "Ingrese el monto del prestamo";
            // 
            // label_interes
            // 
            label_interes.AutoSize = true;
            label_interes.Font = new Font("Times New Roman", 14F);
            label_interes.Location = new Point(358, 195);
            label_interes.Margin = new Padding(4, 0, 4, 0);
            label_interes.Name = "label_interes";
            label_interes.Size = new Size(248, 27);
            label_interes.TabIndex = 2;
            label_interes.Text = "Ingrese la tasa de interes";
            label_interes.Click += label3_Click;
            // 
            // label_prestamo
            // 
            label_prestamo.AutoSize = true;
            label_prestamo.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_prestamo.Location = new Point(331, 300);
            label_prestamo.Margin = new Padding(4, 0, 4, 0);
            label_prestamo.Name = "label_prestamo";
            label_prestamo.Size = new Size(282, 26);
            label_prestamo.TabIndex = 3;
            label_prestamo.Text = "Ingrese el plazo del prestamo";
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Font = new Font("Times New Roman", 14F);
            label_Total.Location = new Point(129, 560);
            label_Total.Margin = new Padding(4, 0, 4, 0);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(60, 27);
            label_Total.TabIndex = 4;
            label_Total.Text = "Total";
            // 
            // textBox_Monto
            // 
            textBox_Monto.Location = new Point(459, 153);
            textBox_Monto.Margin = new Padding(4, 4, 4, 4);
            textBox_Monto.Name = "textBox_Monto";
            textBox_Monto.Size = new Size(170, 34);
            textBox_Monto.TabIndex = 5;
            // 
            // textBox_Interes
            // 
            textBox_Interes.Location = new Point(459, 237);
            textBox_Interes.Margin = new Padding(4, 4, 4, 4);
            textBox_Interes.Name = "textBox_Interes";
            textBox_Interes.Size = new Size(170, 34);
            textBox_Interes.TabIndex = 6;
            // 
            // textBox_Plazo
            // 
            textBox_Plazo.Location = new Point(459, 360);
            textBox_Plazo.Margin = new Padding(4, 4, 4, 4);
            textBox_Plazo.Name = "textBox_Plazo";
            textBox_Plazo.Size = new Size(170, 34);
            textBox_Plazo.TabIndex = 7;
            // 
            // button_Calcular
            // 
            button_Calcular.BackColor = SystemColors.MenuHighlight;
            button_Calcular.Font = new Font("Times New Roman", 14F);
            button_Calcular.Location = new Point(443, 440);
            button_Calcular.Margin = new Padding(4, 4, 4, 4);
            button_Calcular.Name = "button_Calcular";
            button_Calcular.Size = new Size(188, 60);
            button_Calcular.TabIndex = 8;
            button_Calcular.Text = "Calcular";
            button_Calcular.UseVisualStyleBackColor = false;
            button_Calcular.Click += button_Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1100, 630);
            Controls.Add(button_Calcular);
            Controls.Add(textBox_Plazo);
            Controls.Add(textBox_Interes);
            Controls.Add(textBox_Monto);
            Controls.Add(label_Total);
            Controls.Add(label_prestamo);
            Controls.Add(label_interes);
            Controls.Add(label_monto);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Calculadora de cuotas de prestamo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_monto;
        private Label label_interes;
        private Label label_prestamo;
        private Label label_Total;
        private TextBox textBox_Monto;
        private TextBox textBox_Interes;
        private TextBox textBox_Plazo;
        private Button button_Calcular;
    }
}
