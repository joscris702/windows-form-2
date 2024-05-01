namespace Desafio1
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
            this.lbl_montoInicial = new System.Windows.Forms.Label();
            this.lbl_Interes_anueal = new System.Windows.Forms.Label();
            this.lbl_Inversion = new System.Windows.Forms.Label();
            this.txt_Periodo_Inversion = new System.Windows.Forms.TextBox();
            this.txt_Interes = new System.Windows.Forms.TextBox();
            this.txt_Monto_Inicial = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAPITAL FINAL";
            // 
            // lbl_montoInicial
            // 
            this.lbl_montoInicial.AutoSize = true;
            this.lbl_montoInicial.BackColor = System.Drawing.Color.Crimson;
            this.lbl_montoInicial.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montoInicial.Location = new System.Drawing.Point(33, 79);
            this.lbl_montoInicial.Name = "lbl_montoInicial";
            this.lbl_montoInicial.Size = new System.Drawing.Size(171, 26);
            this.lbl_montoInicial.TabIndex = 1;
            this.lbl_montoInicial.Text = "MONTO INICIAL";
            this.lbl_montoInicial.Click += new System.EventHandler(this.lbl_montoInicial_Click);
            // 
            // lbl_Interes_anueal
            // 
            this.lbl_Interes_anueal.AutoSize = true;
            this.lbl_Interes_anueal.BackColor = System.Drawing.Color.Crimson;
            this.lbl_Interes_anueal.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Interes_anueal.Location = new System.Drawing.Point(345, 79);
            this.lbl_Interes_anueal.Name = "lbl_Interes_anueal";
            this.lbl_Interes_anueal.Size = new System.Drawing.Size(170, 26);
            this.lbl_Interes_anueal.TabIndex = 2;
            this.lbl_Interes_anueal.Text = "INTERES ANUAL";
            // 
            // lbl_Inversion
            // 
            this.lbl_Inversion.AutoSize = true;
            this.lbl_Inversion.BackColor = System.Drawing.Color.Crimson;
            this.lbl_Inversion.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inversion.Location = new System.Drawing.Point(598, 79);
            this.lbl_Inversion.Name = "lbl_Inversion";
            this.lbl_Inversion.Size = new System.Drawing.Size(259, 26);
            this.lbl_Inversion.TabIndex = 3;
            this.lbl_Inversion.Text = "PERIODO DE INVERSION";
            // 
            // txt_Periodo_Inversion
            // 
            this.txt_Periodo_Inversion.Location = new System.Drawing.Point(656, 122);
            this.txt_Periodo_Inversion.Name = "txt_Periodo_Inversion";
            this.txt_Periodo_Inversion.Size = new System.Drawing.Size(160, 22);
            this.txt_Periodo_Inversion.TabIndex = 4;
            // 
            // txt_Interes
            // 
            this.txt_Interes.Location = new System.Drawing.Point(359, 122);
            this.txt_Interes.Name = "txt_Interes";
            this.txt_Interes.Size = new System.Drawing.Size(157, 22);
            this.txt_Interes.TabIndex = 5;
            // 
            // txt_Monto_Inicial
            // 
            this.txt_Monto_Inicial.Location = new System.Drawing.Point(50, 122);
            this.txt_Monto_Inicial.Name = "txt_Monto_Inicial";
            this.txt_Monto_Inicial.Size = new System.Drawing.Size(145, 22);
            this.txt_Monto_Inicial.TabIndex = 6;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(569, 290);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(109, 16);
            this.lbl_Resultado.TabIndex = 7;
            this.lbl_Resultado.Text = "RESULATADO";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.Coral;
            this.btn_Calcular.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(334, 168);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(202, 43);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Monto_Inicial);
            this.Controls.Add(this.txt_Interes);
            this.Controls.Add(this.txt_Periodo_Inversion);
            this.Controls.Add(this.lbl_Inversion);
            this.Controls.Add(this.lbl_Interes_anueal);
            this.Controls.Add(this.lbl_montoInicial);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "CALCULADORA CAPITAL FINAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_montoInicial;
        private System.Windows.Forms.Label lbl_Interes_anueal;
        private System.Windows.Forms.Label lbl_Inversion;
        private System.Windows.Forms.TextBox txt_Periodo_Inversion;
        private System.Windows.Forms.TextBox txt_Interes;
        private System.Windows.Forms.TextBox txt_Monto_Inicial;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Calcular;
    }
}

