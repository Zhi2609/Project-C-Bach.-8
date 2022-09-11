namespace Aplicacon_2
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CursoVC = new System.Windows.Forms.CheckBox();
            this.CursoVC2 = new System.Windows.Forms.CheckBox();
            this.PagoCredito = new System.Windows.Forms.RadioButton();
            this.PagoPaypal = new System.Windows.Forms.RadioButton();
            this.PagoOxxo = new System.Windows.Forms.RadioButton();
            this.CursoPy = new System.Windows.Forms.CheckBox();
            this.BTNComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(598, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cursos en Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(563, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Formas de Pago";
            // 
            // CursoVC
            // 
            this.CursoVC.AutoSize = true;
            this.CursoVC.BackColor = System.Drawing.Color.Transparent;
            this.CursoVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.CursoVC.ForeColor = System.Drawing.SystemColors.Control;
            this.CursoVC.Location = new System.Drawing.Point(54, 108);
            this.CursoVC.Name = "CursoVC";
            this.CursoVC.Size = new System.Drawing.Size(163, 29);
            this.CursoVC.TabIndex = 4;
            this.CursoVC.Text = "Curso en C++";
            this.CursoVC.UseVisualStyleBackColor = false;
            // 
            // CursoVC2
            // 
            this.CursoVC2.AutoSize = true;
            this.CursoVC2.BackColor = System.Drawing.Color.Transparent;
            this.CursoVC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.CursoVC2.ForeColor = System.Drawing.SystemColors.Control;
            this.CursoVC2.Location = new System.Drawing.Point(50, 171);
            this.CursoVC2.Name = "CursoVC2";
            this.CursoVC2.Size = new System.Drawing.Size(151, 29);
            this.CursoVC2.TabIndex = 5;
            this.CursoVC2.Text = "Curso en C#";
            this.CursoVC2.UseVisualStyleBackColor = false;
            // 
            // PagoCredito
            // 
            this.PagoCredito.AutoSize = true;
            this.PagoCredito.BackColor = System.Drawing.Color.Transparent;
            this.PagoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.PagoCredito.ForeColor = System.Drawing.Color.Transparent;
            this.PagoCredito.Location = new System.Drawing.Point(546, 107);
            this.PagoCredito.Name = "PagoCredito";
            this.PagoCredito.Size = new System.Drawing.Size(202, 29);
            this.PagoCredito.TabIndex = 6;
            this.PagoCredito.TabStop = true;
            this.PagoCredito.Text = "Tarjeta de Credito";
            this.PagoCredito.UseVisualStyleBackColor = false;
            // 
            // PagoPaypal
            // 
            this.PagoPaypal.AutoSize = true;
            this.PagoPaypal.BackColor = System.Drawing.Color.Transparent;
            this.PagoPaypal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.PagoPaypal.ForeColor = System.Drawing.SystemColors.Control;
            this.PagoPaypal.Location = new System.Drawing.Point(546, 170);
            this.PagoPaypal.Name = "PagoPaypal";
            this.PagoPaypal.Size = new System.Drawing.Size(96, 29);
            this.PagoPaypal.TabIndex = 7;
            this.PagoPaypal.TabStop = true;
            this.PagoPaypal.Text = "Paypal";
            this.PagoPaypal.UseVisualStyleBackColor = false;
            // 
            // PagoOxxo
            // 
            this.PagoOxxo.AutoSize = true;
            this.PagoOxxo.BackColor = System.Drawing.Color.Transparent;
            this.PagoOxxo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.PagoOxxo.ForeColor = System.Drawing.SystemColors.Control;
            this.PagoOxxo.Location = new System.Drawing.Point(546, 233);
            this.PagoOxxo.Name = "PagoOxxo";
            this.PagoOxxo.Size = new System.Drawing.Size(176, 29);
            this.PagoOxxo.TabIndex = 8;
            this.PagoOxxo.TabStop = true;
            this.PagoOxxo.Text = "Pago en OXXO";
            this.PagoOxxo.UseVisualStyleBackColor = false;
            // 
            // CursoPy
            // 
            this.CursoPy.AutoSize = true;
            this.CursoPy.BackColor = System.Drawing.Color.Transparent;
            this.CursoPy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.CursoPy.ForeColor = System.Drawing.SystemColors.Control;
            this.CursoPy.Location = new System.Drawing.Point(50, 244);
            this.CursoPy.Name = "CursoPy";
            this.CursoPy.Size = new System.Drawing.Size(191, 29);
            this.CursoPy.TabIndex = 9;
            this.CursoPy.Text = "Curso en Python";
            this.CursoPy.UseVisualStyleBackColor = false;
            // 
            // BTNComprar
            // 
            this.BTNComprar.Location = new System.Drawing.Point(461, 353);
            this.BTNComprar.Name = "BTNComprar";
            this.BTNComprar.Size = new System.Drawing.Size(105, 53);
            this.BTNComprar.TabIndex = 10;
            this.BTNComprar.Text = "Comprar";
            this.BTNComprar.UseVisualStyleBackColor = true;
            this.BTNComprar.Click += new System.EventHandler(this.BTNComprar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNComprar);
            this.Controls.Add(this.CursoPy);
            this.Controls.Add(this.PagoOxxo);
            this.Controls.Add(this.PagoPaypal);
            this.Controls.Add(this.PagoCredito);
            this.Controls.Add(this.CursoVC2);
            this.Controls.Add(this.CursoVC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CursoVC;
        private System.Windows.Forms.CheckBox CursoVC2;
        private System.Windows.Forms.RadioButton PagoCredito;
        private System.Windows.Forms.RadioButton PagoPaypal;
        private System.Windows.Forms.RadioButton PagoOxxo;
        private System.Windows.Forms.CheckBox CursoPy;
        private System.Windows.Forms.Button BTNComprar;
    }
}