namespace logica
{
    partial class frmExercicioFor1
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
            this.btnContar = new System.Windows.Forms.Button();
            this.listContagem = new System.Windows.Forms.ListBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(104, 12);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(92, 30);
            this.btnContar.TabIndex = 0;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // listContagem
            // 
            this.listContagem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listContagem.FormattingEnabled = true;
            this.listContagem.ItemHeight = 22;
            this.listContagem.Location = new System.Drawing.Point(53, 82);
            this.listContagem.Name = "listContagem";
            this.listContagem.Size = new System.Drawing.Size(189, 158);
            this.listContagem.TabIndex = 1;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(96, 48);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 2;
            // 
            // frmExercicioFor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 299);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.listContagem);
            this.Controls.Add(this.btnContar);
            this.Name = "frmExercicioFor1";
            this.Text = "frmExercicioFor1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.ListBox listContagem;
        private System.Windows.Forms.TextBox txtQtd;
    }
}