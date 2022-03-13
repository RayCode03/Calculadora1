namespace Calculadora1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_divicion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tex_resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora básica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(36, 265);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(75, 23);
            this.btn_suma.TabIndex = 6;
            this.btn_suma.Text = "Sumar";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.Location = new System.Drawing.Point(143, 265);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(75, 23);
            this.btn_resta.TabIndex = 7;
            this.btn_resta.Text = "Restar";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(256, 265);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(75, 23);
            this.btn_multiplicar.TabIndex = 8;
            this.btn_multiplicar.Text = "Multiplicar";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn_divicion
            // 
            this.btn_divicion.Location = new System.Drawing.Point(363, 265);
            this.btn_divicion.Name = "btn_divicion";
            this.btn_divicion.Size = new System.Drawing.Size(75, 23);
            this.btn_divicion.TabIndex = 9;
            this.btn_divicion.Text = "Dividir";
            this.btn_divicion.UseVisualStyleBackColor = true;
            this.btn_divicion.Click += new System.EventHandler(this.btn_divicion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado";
            // 
            // tex_resultado
            // 
            this.tex_resultado.Location = new System.Drawing.Point(112, 193);
            this.tex_resultado.Name = "tex_resultado";
            this.tex_resultado.Size = new System.Drawing.Size(106, 20);
            this.tex_resultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 338);
            this.Controls.Add(this.tex_resultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_divicion);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_divicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tex_resultado;
    }
}

