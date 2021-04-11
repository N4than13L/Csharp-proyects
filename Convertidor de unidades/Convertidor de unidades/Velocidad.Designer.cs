
namespace Convertidor_de_unidades
{
    partial class Velocidad
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
            this.button_calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton_ms_a_kmh = new System.Windows.Forms.RadioButton();
            this.radioButton_kmh_a_ms = new System.Windows.Forms.RadioButton();
            this.textBox_Velocidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_calcular.Location = new System.Drawing.Point(13, 367);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(215, 47);
            this.button_calcular.TabIndex = 0;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton_ms_a_kmh);
            this.groupBox1.Controls.Add(this.radioButton_kmh_a_ms);
            this.groupBox1.Location = new System.Drawing.Point(353, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(20, 124);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(326, 34);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pie/Segundo a metros/Segundo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton_ms_a_kmh
            // 
            this.radioButton_ms_a_kmh.AutoSize = true;
            this.radioButton_ms_a_kmh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_ms_a_kmh.Location = new System.Drawing.Point(20, 83);
            this.radioButton_ms_a_kmh.Name = "radioButton_ms_a_kmh";
            this.radioButton_ms_a_kmh.Size = new System.Drawing.Size(355, 34);
            this.radioButton_ms_a_kmh.TabIndex = 1;
            this.radioButton_ms_a_kmh.TabStop = true;
            this.radioButton_ms_a_kmh.Text = "Metros/segundo a Kilometros/hora";
            this.radioButton_ms_a_kmh.UseVisualStyleBackColor = true;
            // 
            // radioButton_kmh_a_ms
            // 
            this.radioButton_kmh_a_ms.AutoSize = true;
            this.radioButton_kmh_a_ms.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_kmh_a_ms.Location = new System.Drawing.Point(20, 39);
            this.radioButton_kmh_a_ms.Name = "radioButton_kmh_a_ms";
            this.radioButton_kmh_a_ms.Size = new System.Drawing.Size(390, 34);
            this.radioButton_kmh_a_ms.TabIndex = 0;
            this.radioButton_kmh_a_ms.TabStop = true;
            this.radioButton_kmh_a_ms.Text = "de Kilometros/hora a Metros/segundo ";
            this.radioButton_kmh_a_ms.UseVisualStyleBackColor = true;
            // 
            // textBox_Velocidad
            // 
            this.textBox_Velocidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Velocidad.Location = new System.Drawing.Point(13, 47);
            this.textBox_Velocidad.Name = "textBox_Velocidad";
            this.textBox_Velocidad.Size = new System.Drawing.Size(288, 35);
            this.textBox_Velocidad.TabIndex = 2;
            this.textBox_Velocidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Velocidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultado es:";
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Resultado.Location = new System.Drawing.Point(13, 151);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(24, 30);
            this.label_Resultado.TabIndex = 4;
            this.label_Resultado.Text = "0";
            // 
            // Velocidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 441);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Velocidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_calcular);
            this.Name = "Velocidad";
            this.Text = "Velocidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton_ms_a_kmh;
        private System.Windows.Forms.RadioButton radioButton_kmh_a_ms;
        private System.Windows.Forms.TextBox textBox_Velocidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Resultado;
    }
}