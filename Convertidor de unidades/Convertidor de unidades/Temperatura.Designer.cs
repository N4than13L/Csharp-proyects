
namespace Convertidor_de_unidades
{
    partial class Temperatura
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Cel_a_Far = new System.Windows.Forms.RadioButton();
            this.radioButton_Far_a_Kel = new System.Windows.Forms.RadioButton();
            this.radioButton_Far_a_Cel = new System.Windows.Forms.RadioButton();
            this.radioButton_Cel_a_Kel = new System.Windows.Forms.RadioButton();
            this.radioButton_Kel_a_Far = new System.Windows.Forms.RadioButton();
            this.radioButton_Kel_a_Cel = new System.Windows.Forms.RadioButton();
            this.button_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_resultado = new System.Windows.Forms.Label();
            this.textBox_Temperatura = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Cel_a_Far);
            this.groupBox1.Controls.Add(this.radioButton_Far_a_Kel);
            this.groupBox1.Controls.Add(this.radioButton_Far_a_Cel);
            this.groupBox1.Controls.Add(this.radioButton_Cel_a_Kel);
            this.groupBox1.Controls.Add(this.radioButton_Kel_a_Far);
            this.groupBox1.Controls.Add(this.radioButton_Kel_a_Cel);
            this.groupBox1.Location = new System.Drawing.Point(293, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "unidades a convertir";
            // 
            // radioButton_Cel_a_Far
            // 
            this.radioButton_Cel_a_Far.AutoSize = true;
            this.radioButton_Cel_a_Far.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Cel_a_Far.Location = new System.Drawing.Point(36, 321);
            this.radioButton_Cel_a_Far.Name = "radioButton_Cel_a_Far";
            this.radioButton_Cel_a_Far.Size = new System.Drawing.Size(203, 34);
            this.radioButton_Cel_a_Far.TabIndex = 5;
            this.radioButton_Cel_a_Far.TabStop = true;
            this.radioButton_Cel_a_Far.Text = "Celsius a Farenheit";
            this.radioButton_Cel_a_Far.UseVisualStyleBackColor = true;
            // 
            // radioButton_Far_a_Kel
            // 
            this.radioButton_Far_a_Kel.AutoSize = true;
            this.radioButton_Far_a_Kel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Far_a_Kel.Location = new System.Drawing.Point(36, 270);
            this.radioButton_Far_a_Kel.Name = "radioButton_Far_a_Kel";
            this.radioButton_Far_a_Kel.Size = new System.Drawing.Size(194, 34);
            this.radioButton_Far_a_Kel.TabIndex = 4;
            this.radioButton_Far_a_Kel.TabStop = true;
            this.radioButton_Far_a_Kel.Text = "Farenheit a Kelvin";
            this.radioButton_Far_a_Kel.UseVisualStyleBackColor = true;
            // 
            // radioButton_Far_a_Cel
            // 
            this.radioButton_Far_a_Cel.AutoSize = true;
            this.radioButton_Far_a_Cel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Far_a_Cel.Location = new System.Drawing.Point(36, 213);
            this.radioButton_Far_a_Cel.Name = "radioButton_Far_a_Cel";
            this.radioButton_Far_a_Cel.Size = new System.Drawing.Size(203, 34);
            this.radioButton_Far_a_Cel.TabIndex = 3;
            this.radioButton_Far_a_Cel.TabStop = true;
            this.radioButton_Far_a_Cel.Text = "Farenheit a Celsius";
            this.radioButton_Far_a_Cel.UseVisualStyleBackColor = true;
            // 
            // radioButton_Cel_a_Kel
            // 
            this.radioButton_Cel_a_Kel.AutoSize = true;
            this.radioButton_Cel_a_Kel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Cel_a_Kel.Location = new System.Drawing.Point(36, 157);
            this.radioButton_Cel_a_Kel.Name = "radioButton_Cel_a_Kel";
            this.radioButton_Cel_a_Kel.Size = new System.Drawing.Size(173, 34);
            this.radioButton_Cel_a_Kel.TabIndex = 2;
            this.radioButton_Cel_a_Kel.TabStop = true;
            this.radioButton_Cel_a_Kel.Text = "Celsius a Kelvin";
            this.radioButton_Cel_a_Kel.UseVisualStyleBackColor = true;
            // 
            // radioButton_Kel_a_Far
            // 
            this.radioButton_Kel_a_Far.AutoSize = true;
            this.radioButton_Kel_a_Far.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Kel_a_Far.Location = new System.Drawing.Point(36, 99);
            this.radioButton_Kel_a_Far.Name = "radioButton_Kel_a_Far";
            this.radioButton_Kel_a_Far.Size = new System.Drawing.Size(194, 34);
            this.radioButton_Kel_a_Far.TabIndex = 1;
            this.radioButton_Kel_a_Far.TabStop = true;
            this.radioButton_Kel_a_Far.Text = "Kelvin a Farenheit";
            this.radioButton_Kel_a_Far.UseVisualStyleBackColor = true;
            // 
            // radioButton_Kel_a_Cel
            // 
            this.radioButton_Kel_a_Cel.AutoSize = true;
            this.radioButton_Kel_a_Cel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Kel_a_Cel.Location = new System.Drawing.Point(36, 48);
            this.radioButton_Kel_a_Cel.Name = "radioButton_Kel_a_Cel";
            this.radioButton_Kel_a_Cel.Size = new System.Drawing.Size(173, 34);
            this.radioButton_Kel_a_Cel.TabIndex = 0;
            this.radioButton_Kel_a_Cel.TabStop = true;
            this.radioButton_Kel_a_Cel.Text = "Kelvin a Celsius";
            this.radioButton_Kel_a_Cel.UseVisualStyleBackColor = true;
            // 
            // button_calcular
            // 
            this.button_calcular.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_calcular.Location = new System.Drawing.Point(12, 350);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(183, 48);
            this.button_calcular.TabIndex = 1;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultado es:";
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_resultado.Location = new System.Drawing.Point(28, 140);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(24, 30);
            this.label_resultado.TabIndex = 3;
            this.label_resultado.Text = "0";
            // 
            // textBox_Temperatura
            // 
            this.textBox_Temperatura.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Temperatura.Location = new System.Drawing.Point(28, 39);
            this.textBox_Temperatura.Name = "textBox_Temperatura";
            this.textBox_Temperatura.Size = new System.Drawing.Size(250, 35);
            this.textBox_Temperatura.TabIndex = 4;
            this.textBox_Temperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Temperatura_KeyPress);
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 416);
            this.Controls.Add(this.textBox_Temperatura);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Temperatura";
            this.Text = "Temperatura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Cel_a_Far;
        private System.Windows.Forms.RadioButton radioButton_Far_a_Kel;
        private System.Windows.Forms.RadioButton radioButton_Far_a_Cel;
        private System.Windows.Forms.RadioButton radioButton_Cel_a_Kel;
        private System.Windows.Forms.RadioButton radioButton_Kel_a_Far;
        private System.Windows.Forms.RadioButton radioButton_Kel_a_Cel;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox textBox_Temperatura;
    }
}