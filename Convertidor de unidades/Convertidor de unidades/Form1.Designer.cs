
namespace Convertidor_de_unidades
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_Calcular = new System.Windows.Forms.Button();
            this.txt_valores = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.Celcius_Kelvin = new System.Windows.Forms.RadioButton();
            this.farenheit_celcius = new System.Windows.Forms.RadioButton();
            this.farenheit_a_kelvin = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(0, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 390);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.farenheit_a_kelvin);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.boton_Calcular);
            this.groupBox3.Controls.Add(this.txt_valores);
            this.groupBox3.Controls.Add(this.Resultado);
            this.groupBox3.Controls.Add(this.farenheit_celcius);
            this.groupBox3.Controls.Add(this.Celcius_Kelvin);
            this.groupBox3.Location = new System.Drawing.Point(111, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(677, 383);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-394, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "resultado es:";
            // 
            // boton_Calcular
            // 
            this.boton_Calcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boton_Calcular.Location = new System.Drawing.Point(22, 336);
            this.boton_Calcular.Name = "boton_Calcular";
            this.boton_Calcular.Size = new System.Drawing.Size(104, 38);
            this.boton_Calcular.TabIndex = 2;
            this.boton_Calcular.Text = "Calcular";
            this.boton_Calcular.UseVisualStyleBackColor = true;
            this.boton_Calcular.Click += new System.EventHandler(this.boton_Calcular_Click);
            // 
            // txt_valores
            // 
            this.txt_valores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valores.Location = new System.Drawing.Point(23, 31);
            this.txt_valores.Name = "txt_valores";
            this.txt_valores.Size = new System.Drawing.Size(157, 29);
            this.txt_valores.TabIndex = 0;
            this.txt_valores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valores_KeyPress);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resultado.Location = new System.Drawing.Point(139, 64);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(19, 21);
            this.Resultado.TabIndex = 1;
            this.Resultado.Text = "0";
            // 
            // Celcius_Kelvin
            // 
            this.Celcius_Kelvin.AutoSize = true;
            this.Celcius_Kelvin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Celcius_Kelvin.Location = new System.Drawing.Point(487, 35);
            this.Celcius_Kelvin.Name = "Celcius_Kelvin";
            this.Celcius_Kelvin.Size = new System.Drawing.Size(75, 25);
            this.Celcius_Kelvin.TabIndex = 0;
            this.Celcius_Kelvin.TabStop = true;
            this.Celcius_Kelvin.Text = "°C a °K";
            this.Celcius_Kelvin.UseVisualStyleBackColor = true;
            // 
            // farenheit_celcius
            // 
            this.farenheit_celcius.AutoSize = true;
            this.farenheit_celcius.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.farenheit_celcius.Location = new System.Drawing.Point(487, 60);
            this.farenheit_celcius.Name = "farenheit_celcius";
            this.farenheit_celcius.Size = new System.Drawing.Size(74, 25);
            this.farenheit_celcius.TabIndex = 0;
            this.farenheit_celcius.TabStop = true;
            this.farenheit_celcius.Text = "°F a °C";
            this.farenheit_celcius.UseVisualStyleBackColor = true;
            // 
            // farenheit_a_kelvin
            // 
            this.farenheit_a_kelvin.AutoSize = true;
            this.farenheit_a_kelvin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.farenheit_a_kelvin.Location = new System.Drawing.Point(488, 91);
            this.farenheit_a_kelvin.Name = "farenheit_a_kelvin";
            this.farenheit_a_kelvin.Size = new System.Drawing.Size(72, 25);
            this.farenheit_a_kelvin.TabIndex = 5;
            this.farenheit_a_kelvin.TabStop = true;
            this.farenheit_a_kelvin.Text = "°F a °k";
            this.farenheit_a_kelvin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Conversor de Uniades ";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_valores;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.RadioButton Celcius_Kelvin;
        private System.Windows.Forms.Button boton_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton farenheit_a_kelvin;
        private System.Windows.Forms.RadioButton farenheit_celcius;
    }
}

