namespace logica
{
    partial class frmLinq2
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
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtNumeroPaginas = new System.Windows.Forms.TextBox();
            this.lblFiccao = new System.Windows.Forms.Label();
            this.listBoxNaoFiccao = new System.Windows.Forms.ListBox();
            this.listBoxRomance = new System.Windows.Forms.ListBox();
            this.listBoxFiccao = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeroPesquisa = new System.Windows.Forms.TextBox();
            this.cbGeneroPesquisa = new System.Windows.Forms.ComboBox();
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "FICÇÃO",
            "NÃO-FICÇÃO",
            "ROMANCE"});
            this.cbGenero.Location = new System.Drawing.Point(244, 9);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(153, 30);
            this.cbGenero.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(185, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(94, 9);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(140, 22);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Gênero do livro";
            // 
            // txtNumeroPaginas
            // 
            this.txtNumeroPaginas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPaginas.Location = new System.Drawing.Point(244, 56);
            this.txtNumeroPaginas.Name = "txtNumeroPaginas";
            this.txtNumeroPaginas.Size = new System.Drawing.Size(153, 29);
            this.txtNumeroPaginas.TabIndex = 2;
            // 
            // lblFiccao
            // 
            this.lblFiccao.AutoSize = true;
            this.lblFiccao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiccao.Location = new System.Drawing.Point(50, 188);
            this.lblFiccao.Name = "lblFiccao";
            this.lblFiccao.Size = new System.Drawing.Size(67, 22);
            this.lblFiccao.TabIndex = 2;
            this.lblFiccao.Text = "Ficção";
            // 
            // listBoxNaoFiccao
            // 
            this.listBoxNaoFiccao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNaoFiccao.FormattingEnabled = true;
            this.listBoxNaoFiccao.ItemHeight = 22;
            this.listBoxNaoFiccao.Location = new System.Drawing.Point(161, 222);
            this.listBoxNaoFiccao.Name = "listBoxNaoFiccao";
            this.listBoxNaoFiccao.Size = new System.Drawing.Size(143, 136);
            this.listBoxNaoFiccao.TabIndex = 4;
            // 
            // listBoxRomance
            // 
            this.listBoxRomance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRomance.FormattingEnabled = true;
            this.listBoxRomance.ItemHeight = 22;
            this.listBoxRomance.Location = new System.Drawing.Point(310, 222);
            this.listBoxRomance.Name = "listBoxRomance";
            this.listBoxRomance.Size = new System.Drawing.Size(143, 136);
            this.listBoxRomance.TabIndex = 4;
            // 
            // listBoxFiccao
            // 
            this.listBoxFiccao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFiccao.FormattingEnabled = true;
            this.listBoxFiccao.ItemHeight = 22;
            this.listBoxFiccao.Location = new System.Drawing.Point(12, 222);
            this.listBoxFiccao.Name = "listBoxFiccao";
            this.listBoxFiccao.Size = new System.Drawing.Size(143, 136);
            this.listBoxFiccao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Não-Ficção";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Romance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Páginas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opções para pesquisa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gênero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(566, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Opção";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Número páginas";
            // 
            // txtNumeroPesquisa
            // 
            this.txtNumeroPesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPesquisa.Location = new System.Drawing.Point(639, 154);
            this.txtNumeroPesquisa.Name = "txtNumeroPesquisa";
            this.txtNumeroPesquisa.Size = new System.Drawing.Size(153, 29);
            this.txtNumeroPesquisa.TabIndex = 2;
            // 
            // cbGeneroPesquisa
            // 
            this.cbGeneroPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeneroPesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeneroPesquisa.FormattingEnabled = true;
            this.cbGeneroPesquisa.Items.AddRange(new object[] {
            "FICÇÃO",
            "NÃO-FICÇÃO",
            "ROMANCE"});
            this.cbGeneroPesquisa.Location = new System.Drawing.Point(639, 70);
            this.cbGeneroPesquisa.Name = "cbGeneroPesquisa";
            this.cbGeneroPesquisa.Size = new System.Drawing.Size(153, 30);
            this.cbGeneroPesquisa.TabIndex = 1;
            // 
            // cbOpcao
            // 
            this.cbOpcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "ACIMA",
            "IGUAL",
            "ABAIXO"});
            this.cbOpcao.Location = new System.Drawing.Point(639, 112);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(153, 30);
            this.cbOpcao.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(570, 222);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(196, 68);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar com LAMBDA";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmLinq2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 384);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxRomance);
            this.Controls.Add(this.listBoxFiccao);
            this.Controls.Add(this.listBoxNaoFiccao);
            this.Controls.Add(this.txtNumeroPesquisa);
            this.Controls.Add(this.txtNumeroPaginas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFiccao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbOpcao);
            this.Controls.Add(this.cbGeneroPesquisa);
            this.Controls.Add(this.cbGenero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLinq2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLinq2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtNumeroPaginas;
        private System.Windows.Forms.Label lblFiccao;
        private System.Windows.Forms.ListBox listBoxNaoFiccao;
        private System.Windows.Forms.ListBox listBoxRomance;
        private System.Windows.Forms.ListBox listBoxFiccao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumeroPesquisa;
        private System.Windows.Forms.ComboBox cbGeneroPesquisa;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.Button btnPesquisar;
    }
}