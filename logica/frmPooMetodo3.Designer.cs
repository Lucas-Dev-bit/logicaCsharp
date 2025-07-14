namespace logica
{
    partial class frmPooMetodo3
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
            this.listBoxCidade = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroHabitantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRendaMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxExpansao = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCidade
            // 
            this.listBoxCidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCidade.FormattingEnabled = true;
            this.listBoxCidade.ItemHeight = 22;
            this.listBoxCidade.Location = new System.Drawing.Point(12, 223);
            this.listBoxCidade.Name = "listBoxCidade";
            this.listBoxCidade.Size = new System.Drawing.Size(177, 158);
            this.listBoxCidade.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Cidade";
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCidade.Location = new System.Drawing.Point(329, 14);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(209, 29);
            this.txtNomeCidade.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(329, 127);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 41);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de Habitantes";
            // 
            // txtNumeroHabitantes
            // 
            this.txtNumeroHabitantes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroHabitantes.Location = new System.Drawing.Point(329, 47);
            this.txtNumeroHabitantes.Name = "txtNumeroHabitantes";
            this.txtNumeroHabitantes.Size = new System.Drawing.Size(120, 29);
            this.txtNumeroHabitantes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Renda média";
            // 
            // txtRendaMedia
            // 
            this.txtRendaMedia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRendaMedia.Location = new System.Drawing.Point(329, 82);
            this.txtRendaMedia.Name = "txtRendaMedia";
            this.txtRendaMedia.Size = new System.Drawing.Size(120, 29);
            this.txtRendaMedia.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cidade";
            // 
            // listBoxExpansao
            // 
            this.listBoxExpansao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExpansao.FormattingEnabled = true;
            this.listBoxExpansao.ItemHeight = 22;
            this.listBoxExpansao.Location = new System.Drawing.Point(195, 223);
            this.listBoxExpansao.Name = "listBoxExpansao";
            this.listBoxExpansao.Size = new System.Drawing.Size(607, 158);
            this.listBoxExpansao.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Análise de Expansão";
            // 
            // frmPooMetodo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 392);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRendaMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroHabitantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxExpansao);
            this.Controls.Add(this.listBoxCidade);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPooMetodo3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPooMetodo3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCidade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroHabitantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRendaMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxExpansao;
        private System.Windows.Forms.Label label5;
    }
}