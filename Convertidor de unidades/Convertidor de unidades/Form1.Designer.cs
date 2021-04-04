
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
            this.Velocidad = new System.Windows.Forms.Button();
            this.Temperatura = new System.Windows.Forms.Button();
            this.gbx_temperatura = new System.Windows.Forms.GroupBox();
            this.farenheit_a_kelvin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_Calcular = new System.Windows.Forms.Button();
            this.txt_valores = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.farenheit_celcius = new System.Windows.Forms.RadioButton();
            this.Celcius_Kelvin = new System.Windows.Forms.RadioButton();
            this.gbx_Velocidad = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Velocidad = new System.Windows.Forms.TextBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.Millas_a_Kilometros = new System.Windows.Forms.RadioButton();
            this.Kilometros_a_millas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.gbx_temperatura.SuspendLayout();
            this.gbx_Velocidad.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.Velocidad);
            this.groupBox2.Controls.Add(this.Temperatura);
            this.groupBox2.Location = new System.Drawing.Point(0, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 390);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Velocidad
            // 
            this.Velocidad.Location = new System.Drawing.Point(0, 38);
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.Size = new System.Drawing.Size(105, 23);
            this.Velocidad.TabIndex = 1;
            this.Velocidad.Text = "Velocidad";
            this.Velocidad.UseVisualStyleBackColor = true;
            this.Velocidad.Click += new System.EventHandler(this.Velocidad_Click);
            // 
            // Temperatura
            // 
            this.Temperatura.Location = new System.Drawing.Point(0, 8);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(105, 23);
            this.Temperatura.TabIndex = 0;
            this.Temperatura.Text = "Temperatura";
            this.Temperatura.UseVisualStyleBackColor = true;
            this.Temperatura.Click += new System.EventHandler(this.Temperatura_Click);
            // 
            // gbx_temperatura
            // 
            this.gbx_temperatura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_temperatura.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbx_temperatura.Controls.Add(this.gbx_Velocidad);
            this.gbx_temperatura.Controls.Add(this.farenheit_a_kelvin);
            this.gbx_temperatura.Controls.Add(this.label3);
            this.gbx_temperatura.Controls.Add(this.label2);
            this.gbx_temperatura.Controls.Add(this.boton_Calcular);
            this.gbx_temperatura.Controls.Add(this.txt_valores);
            this.gbx_temperatura.Controls.Add(this.Resultado);
            this.gbx_temperatura.Controls.Add(this.farenheit_celcius);
            this.gbx_temperatura.Controls.Add(this.Celcius_Kelvin);
            this.gbx_temperatura.Location = new System.Drawing.Point(111, 55);
            this.gbx_temperatura.Name = "gbx_temperatura";
            this.gbx_temperatura.Size = new System.Drawing.Size(677, 383);
            this.gbx_temperatura.TabIndex = 2;
            this.gbx_temperatura.TabStop = false;
            this.gbx_temperatura.Text = "groupBox3";
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
            // gbx_Velocidad
            // 
            this.gbx_Velocidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_Velocidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbx_Velocidad.Controls.Add(this.lbl_resultado);
            this.gbx_Velocidad.Controls.Add(this.label1);
            this.gbx_Velocidad.Controls.Add(this.Kilometros_a_millas);
            this.gbx_Velocidad.Controls.Add(this.Millas_a_Kilometros);
            this.gbx_Velocidad.Controls.Add(this.button_calcular);
            this.gbx_Velocidad.Controls.Add(this.textBox_Velocidad);
            this.gbx_Velocidad.Controls.Add(this.label4);
            this.gbx_Velocidad.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gbx_Velocidad.Location = new System.Drawing.Point(0, 1);
            this.gbx_Velocidad.Name = "gbx_Velocidad";
            this.gbx_Velocidad.Size = new System.Drawing.Size(677, 383);
            this.gbx_Velocidad.TabIndex = 6;
            this.gbx_Velocidad.TabStop = false;
            this.gbx_Velocidad.Text = "Temperatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-394, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "resultado es:";
            // 
            // textBox_Velocidad
            // 
            this.textBox_Velocidad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Velocidad.Location = new System.Drawing.Point(22, 37);
            this.textBox_Velocidad.Name = "textBox_Velocidad";
            this.textBox_Velocidad.Size = new System.Drawing.Size(191, 33);
            this.textBox_Velocidad.TabIndex = 4;
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(13, 335);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(114, 37);
            this.button_calcular.TabIndex = 5;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // Millas_a_Kilometros
            // 
            this.Millas_a_Kilometros.AutoSize = true;
            this.Millas_a_Kilometros.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Millas_a_Kilometros.Location = new System.Drawing.Point(293, 86);
            this.Millas_a_Kilometros.Name = "Millas_a_Kilometros";
            this.Millas_a_Kilometros.Size = new System.Drawing.Size(188, 29);
            this.Millas_a_Kilometros.TabIndex = 6;
            this.Millas_a_Kilometros.TabStop = true;
            this.Millas_a_Kilometros.Text = "Millas a kilometros";
            this.Millas_a_Kilometros.UseVisualStyleBackColor = true;
            // 
            // Kilometros_a_millas
            // 
            this.Kilometros_a_millas.AutoSize = true;
            this.Kilometros_a_millas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Kilometros_a_millas.Location = new System.Drawing.Point(293, 117);
            this.Kilometros_a_millas.Name = "Kilometros_a_millas";
            this.Kilometros_a_millas.Size = new System.Drawing.Size(187, 29);
            this.Kilometros_a_millas.TabIndex = 7;
            this.Kilometros_a_millas.TabStop = true;
            this.Kilometros_a_millas.Text = "kilometros a millas";
            this.Kilometros_a_millas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultado es:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado.Location = new System.Drawing.Point(149, 73);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(22, 25);
            this.lbl_resultado.TabIndex = 9;
            this.lbl_resultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_temperatura);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Conversor de Uniades ";
            this.groupBox2.ResumeLayout(false);
            this.gbx_temperatura.ResumeLayout(false);
            this.gbx_temperatura.PerformLayout();
            this.gbx_Velocidad.ResumeLayout(false);
            this.gbx_Velocidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbx_temperatura;
        private System.Windows.Forms.TextBox txt_valores;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.RadioButton Celcius_Kelvin;
        private System.Windows.Forms.Button boton_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton farenheit_a_kelvin;
        private System.Windows.Forms.RadioButton farenheit_celcius;
        private System.Windows.Forms.Button Velocidad;
        private System.Windows.Forms.Button Temperatura;
        private System.Windows.Forms.GroupBox gbx_Velocidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Velocidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Kilometros_a_millas;
        private System.Windows.Forms.RadioButton Millas_a_Kilometros;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

