namespace logica
{
    partial class frmListaExemplo2
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listPares = new System.Windows.Forms.ListBox();
            this.listImpares = new System.Windows.Forms.ListBox();
            this.lblPares = new System.Windows.Forms.Label();
            this.lblImpares = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(180, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(79, 23);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(282, 31);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 30);
            this.txtNumero.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(234, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listPares
            // 
            this.listPares.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPares.FormattingEnabled = true;
            this.listPares.ItemHeight = 24;
            this.listPares.Location = new System.Drawing.Point(100, 185);
            this.listPares.Name = "listPares";
            this.listPares.Size = new System.Drawing.Size(201, 172);
            this.listPares.TabIndex = 3;
            // 
            // listImpares
            // 
            this.listImpares.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listImpares.FormattingEnabled = true;
            this.listImpares.ItemHeight = 24;
            this.listImpares.Location = new System.Drawing.Point(323, 185);
            this.listImpares.Name = "listImpares";
            this.listImpares.Size = new System.Drawing.Size(201, 172);
            this.listImpares.TabIndex = 3;
            // 
            // lblPares
            // 
            this.lblPares.AutoSize = true;
            this.lblPares.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPares.Location = new System.Drawing.Point(162, 159);
            this.lblPares.Name = "lblPares";
            this.lblPares.Size = new System.Drawing.Size(75, 23);
            this.lblPares.TabIndex = 0;
            this.lblPares.Text = "PARES";
            // 
            // lblImpares
            // 
            this.lblImpares.AutoSize = true;
            this.lblImpares.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpares.Location = new System.Drawing.Point(376, 159);
            this.lblImpares.Name = "lblImpares";
            this.lblImpares.Size = new System.Drawing.Size(98, 23);
            this.lblImpares.TabIndex = 0;
            this.lblImpares.Text = "ÍMPARES";
            // 
            // frmListaExemplo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.listImpares);
            this.Controls.Add(this.listPares);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblImpares);
            this.Controls.Add(this.lblPares);
            this.Controls.Add(this.lblNumero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaExemplo2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Generics - Exemplo 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listPares;
        private System.Windows.Forms.ListBox listImpares;
        private System.Windows.Forms.Label lblPares;
        private System.Windows.Forms.Label lblImpares;
    }
}