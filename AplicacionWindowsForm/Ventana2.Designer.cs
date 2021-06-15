
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
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnRegresa = new System.Windows.Forms.Button();
            this.comPasarelas = new System.Windows.Forms.ComboBox();
            this.lisProductos = new System.Windows.Forms.ListBox();
            this.imgProductos = new System.Windows.Forms.PictureBox();
            this.imgPasarelas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasarelas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(412, 430);
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
            this.lblResultado.Location = new System.Drawing.Point(119, 509);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(122, 25);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "lblResultado";
            // 
            // btnRegresa
            // 
            this.btnRegresa.Location = new System.Drawing.Point(119, 431);
            this.btnRegresa.Name = "btnRegresa";
            this.btnRegresa.Size = new System.Drawing.Size(110, 34);
            this.btnRegresa.TabIndex = 6;
            this.btnRegresa.Text = "Regresar";
            this.btnRegresa.UseVisualStyleBackColor = true;
            this.btnRegresa.Click += new System.EventHandler(this.btnRegresa_Click);
            // 
            // comPasarelas
            // 
            this.comPasarelas.FormattingEnabled = true;
            this.comPasarelas.Items.AddRange(new object[] {
            "Tarjeta",
            "Paypal"});
            this.comPasarelas.Location = new System.Drawing.Point(380, 74);
            this.comPasarelas.Name = "comPasarelas";
            this.comPasarelas.Size = new System.Drawing.Size(121, 33);
            this.comPasarelas.TabIndex = 7;
            this.comPasarelas.SelectedIndexChanged += new System.EventHandler(this.comPasarelas_SelectedIndexChanged);
            // 
            // lisProductos
            // 
            this.lisProductos.FormattingEnabled = true;
            this.lisProductos.ItemHeight = 25;
            this.lisProductos.Items.AddRange(new object[] {
            "Tenis",
            "Camisas"});
            this.lisProductos.Location = new System.Drawing.Point(97, 74);
            this.lisProductos.Name = "lisProductos";
            this.lisProductos.Size = new System.Drawing.Size(120, 79);
            this.lisProductos.TabIndex = 8;
            this.lisProductos.SelectedIndexChanged += new System.EventHandler(this.lisProductos_SelectedIndexChanged);
            // 
            // imgProductos
            // 
            this.imgProductos.Location = new System.Drawing.Point(97, 191);
            this.imgProductos.Name = "imgProductos";
            this.imgProductos.Size = new System.Drawing.Size(174, 125);
            this.imgProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProductos.TabIndex = 9;
            this.imgProductos.TabStop = false;
            // 
            // imgPasarelas
            // 
            this.imgPasarelas.Location = new System.Drawing.Point(380, 191);
            this.imgPasarelas.Name = "imgPasarelas";
            this.imgPasarelas.Size = new System.Drawing.Size(174, 125);
            this.imgPasarelas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPasarelas.TabIndex = 9;
            this.imgPasarelas.TabStop = false;
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 766);
            this.Controls.Add(this.imgPasarelas);
            this.Controls.Add(this.imgProductos);
            this.Controls.Add(this.lisProductos);
            this.Controls.Add(this.comPasarelas);
            this.Controls.Add(this.btnRegresa);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPagar);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Ventana2";
            this.Text = "Ventana2";
            ((System.ComponentModel.ISupportInitialize)(this.imgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasarelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnRegresa;
        private System.Windows.Forms.ComboBox comPasarelas;
        private System.Windows.Forms.ListBox lisProductos;
        private System.Windows.Forms.PictureBox imgProductos;
        private System.Windows.Forms.PictureBox imgPasarelas;
    }
}