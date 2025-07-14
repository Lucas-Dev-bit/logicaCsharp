namespace logica
{
    partial class frmParImpar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContrarPares = new System.Windows.Forms.Label();
            this.lblContarImpares = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "ÍMPARES";
            // 
            // lblContrarPares
            // 
            this.lblContrarPares.AutoSize = true;
            this.lblContrarPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrarPares.Location = new System.Drawing.Point(156, 142);
            this.lblContrarPares.Name = "lblContrarPares";
            this.lblContrarPares.Size = new System.Drawing.Size(42, 46);
            this.lblContrarPares.TabIndex = 0;
            this.lblContrarPares.Text = "0";
            this.lblContrarPares.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblContarImpares
            // 
            this.lblContarImpares.AutoSize = true;
            this.lblContarImpares.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContarImpares.Location = new System.Drawing.Point(497, 131);
            this.lblContarImpares.Name = "lblContarImpares";
            this.lblContarImpares.Size = new System.Drawing.Size(42, 46);
            this.lblContarImpares.TabIndex = 0;
            this.lblContarImpares.Text = "0";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(213, 233);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(278, 30);
            this.txtNumero.TabIndex = 1;
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(289, 279);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(119, 37);
            this.btnContar.TabIndex = 2;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // frmParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblContarImpares);
            this.Controls.Add(this.lblContrarPares);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmParImpar";
            this.Text = "frmParImpar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContrarPares;
        private System.Windows.Forms.Label lblContarImpares;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnContar;
    }
}