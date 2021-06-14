
namespace AplicacionWindowsForm
{
    partial class Ventana2
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
            this.chkTenis = new System.Windows.Forms.CheckBox();
            this.chkCamisa = new System.Windows.Forms.CheckBox();
            this.radPaypal = new System.Windows.Forms.RadioButton();
            this.radTarjeta = new System.Windows.Forms.RadioButton();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnRegresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkTenis
            // 
            this.chkTenis.AutoSize = true;
            this.chkTenis.Location = new System.Drawing.Point(119, 49);
            this.chkTenis.Name = "chkTenis";
            this.chkTenis.Size = new System.Drawing.Size(143, 29);
            this.chkTenis.TabIndex = 0;
            this.chkTenis.Text = "Tenis (1,000)";
            this.chkTenis.UseVisualStyleBackColor = true;
            // 
            // chkCamisa
            // 
            this.chkCamisa.AutoSize = true;
            this.chkCamisa.Location = new System.Drawing.Point(119, 104);
            this.chkCamisa.Name = "chkCamisa";
            this.chkCamisa.Size = new System.Drawing.Size(145, 29);
            this.chkCamisa.TabIndex = 1;
            this.chkCamisa.Text = "Camisa (500)";
            this.chkCamisa.UseVisualStyleBackColor = true;
            // 
            // radPaypal
            // 
            this.radPaypal.AutoSize = true;
            this.radPaypal.Location = new System.Drawing.Point(416, 49);
            this.radPaypal.Name = "radPaypal";
            this.radPaypal.Size = new System.Drawing.Size(89, 29);
            this.radPaypal.TabIndex = 2;
            this.radPaypal.TabStop = true;
            this.radPaypal.Text = "Paypal";
            this.radPaypal.UseVisualStyleBackColor = true;
            // 
            // radTarjeta
            // 
            this.radTarjeta.AutoSize = true;
            this.radTarjeta.Location = new System.Drawing.Point(416, 104);
            this.radTarjeta.Name = "radTarjeta";
            this.radTarjeta.Size = new System.Drawing.Size(89, 29);
            this.radTarjeta.TabIndex = 3;
            this.radTarjeta.TabStop = true;
            this.radTarjeta.Text = "Tarjeta";
            this.radTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(416, 191);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(89, 35);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(119, 273);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(122, 25);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "lblResultado";
            // 
            // btnRegresa
            // 
            this.btnRegresa.Location = new System.Drawing.Point(119, 191);
            this.btnRegresa.Name = "btnRegresa";
            this.btnRegresa.Size = new System.Drawing.Size(110, 34);
            this.btnRegresa.TabIndex = 6;
            this.btnRegresa.Text = "Regresar";
            this.btnRegresa.UseVisualStyleBackColor = true;
            this.btnRegresa.Click += new System.EventHandler(this.btnRegresa_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresa);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.radTarjeta);
            this.Controls.Add(this.radPaypal);
            this.Controls.Add(this.chkCamisa);
            this.Controls.Add(this.chkTenis);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Ventana2";
            this.Text = "Ventana2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTenis;
        private System.Windows.Forms.CheckBox chkCamisa;
        private System.Windows.Forms.RadioButton radPaypal;
        private System.Windows.Forms.RadioButton radTarjeta;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnRegresa;
    }
}