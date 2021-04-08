
namespace Convertidor_de_unidades
{
    partial class Form_Menu
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
            this.button_densidad = new System.Windows.Forms.Button();
            this.button_temperatura = new System.Windows.Forms.Button();
            this.button_velocidad = new System.Windows.Forms.Button();
            this.button_programación = new System.Windows.Forms.Button();
            this.button_distancia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_densidad
            // 
            this.button_densidad.Location = new System.Drawing.Point(40, 52);
            this.button_densidad.Name = "button_densidad";
            this.button_densidad.Size = new System.Drawing.Size(246, 23);
            this.button_densidad.TabIndex = 0;
            this.button_densidad.Text = "Desidad";
            this.button_densidad.UseVisualStyleBackColor = true;
            this.button_densidad.Click += new System.EventHandler(this.button_densidad_Click);
            // 
            // button_temperatura
            // 
            this.button_temperatura.Location = new System.Drawing.Point(40, 90);
            this.button_temperatura.Name = "button_temperatura";
            this.button_temperatura.Size = new System.Drawing.Size(246, 23);
            this.button_temperatura.TabIndex = 1;
            this.button_temperatura.Text = "Temperatura";
            this.button_temperatura.UseVisualStyleBackColor = true;
            this.button_temperatura.Click += new System.EventHandler(this.button_temperatura_Click);
            // 
            // button_velocidad
            // 
            this.button_velocidad.Location = new System.Drawing.Point(40, 132);
            this.button_velocidad.Name = "button_velocidad";
            this.button_velocidad.Size = new System.Drawing.Size(246, 23);
            this.button_velocidad.TabIndex = 2;
            this.button_velocidad.Text = "Velocidad";
            this.button_velocidad.UseVisualStyleBackColor = true;
            this.button_velocidad.Click += new System.EventHandler(this.button_velocidad_Click);
            // 
            // button_programación
            // 
            this.button_programación.Location = new System.Drawing.Point(40, 178);
            this.button_programación.Name = "button_programación";
            this.button_programación.Size = new System.Drawing.Size(246, 23);
            this.button_programación.TabIndex = 3;
            this.button_programación.Text = "Programación";
            this.button_programación.UseVisualStyleBackColor = true;
            this.button_programación.Click += new System.EventHandler(this.button_programación_Click);
            // 
            // button_distancia
            // 
            this.button_distancia.Location = new System.Drawing.Point(40, 229);
            this.button_distancia.Name = "button_distancia";
            this.button_distancia.Size = new System.Drawing.Size(246, 23);
            this.button_distancia.TabIndex = 4;
            this.button_distancia.Text = "Distancia";
            this.button_distancia.UseVisualStyleBackColor = true;
            this.button_distancia.Click += new System.EventHandler(this.button_distancia_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 503);
            this.Controls.Add(this.button_distancia);
            this.Controls.Add(this.button_programación);
            this.Controls.Add(this.button_velocidad);
            this.Controls.Add(this.button_temperatura);
            this.Controls.Add(this.button_densidad);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Uniades ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_densidad;
        private System.Windows.Forms.Button button_temperatura;
        private System.Windows.Forms.Button button_velocidad;
        private System.Windows.Forms.Button button_programación;
        private System.Windows.Forms.Button button_distancia;
    }
}

