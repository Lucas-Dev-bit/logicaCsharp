namespace logica
{
    partial class frmPooAtributo1
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblSetor = new System.Windows.Forms.Label();
            this.txtNomeSetor = new System.Windows.Forms.TextBox();
            this.lblCoordenador = new System.Windows.Forms.Label();
            this.txtNomeCoordenador = new System.Windows.Forms.TextBox();
            this.lblLider = new System.Windows.Forms.Label();
            this.txtNomeLider = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(260, 250);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(116, 36);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(115, 54);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(139, 22);
            this.lblSetor.TabIndex = 1;
            this.lblSetor.Text = "Nome do Setor";
            // 
            // txtNomeSetor
            // 
            this.txtNomeSetor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSetor.Location = new System.Drawing.Point(260, 47);
            this.txtNomeSetor.Name = "txtNomeSetor";
            this.txtNomeSetor.Size = new System.Drawing.Size(293, 29);
            this.txtNomeSetor.TabIndex = 2;
            // 
            // lblCoordenador
            // 
            this.lblCoordenador.AutoSize = true;
            this.lblCoordenador.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordenador.Location = new System.Drawing.Point(44, 105);
            this.lblCoordenador.Name = "lblCoordenador";
            this.lblCoordenador.Size = new System.Drawing.Size(210, 22);
            this.lblCoordenador.TabIndex = 1;
            this.lblCoordenador.Text = "Nome  do Coordenador";
            // 
            // txtNomeCoordenador
            // 
            this.txtNomeCoordenador.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCoordenador.Location = new System.Drawing.Point(260, 98);
            this.txtNomeCoordenador.Name = "txtNomeCoordenador";
            this.txtNomeCoordenador.Size = new System.Drawing.Size(293, 29);
            this.txtNomeCoordenador.TabIndex = 2;
            // 
            // lblLider
            // 
            this.lblLider.AutoSize = true;
            this.lblLider.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLider.Location = new System.Drawing.Point(23, 156);
            this.lblLider.Name = "lblLider";
            this.lblLider.Size = new System.Drawing.Size(227, 22);
            this.lblLider.TabIndex = 1;
            this.lblLider.Text = "Nome do Líder da equipe";
            // 
            // txtNomeLider
            // 
            this.txtNomeLider.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLider.Location = new System.Drawing.Point(260, 149);
            this.txtNomeLider.Name = "txtNomeLider";
            this.txtNomeLider.Size = new System.Drawing.Size(293, 29);
            this.txtNomeLider.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Qtd Colaboradores";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(260, 200);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(116, 29);
            this.txtQtd.TabIndex = 2;
            // 
            // frmPooAtributo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 311);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeLider);
            this.Controls.Add(this.lblLider);
            this.Controls.Add(this.txtNomeCoordenador);
            this.Controls.Add(this.lblCoordenador);
            this.Controls.Add(this.txtNomeSetor);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.btnMostrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPooAtributo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPooAtributo1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.TextBox txtNomeSetor;
        private System.Windows.Forms.Label lblCoordenador;
        private System.Windows.Forms.TextBox txtNomeCoordenador;
        private System.Windows.Forms.Label lblLider;
        private System.Windows.Forms.TextBox txtNomeLider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQtd;
    }
}