namespace logica
{
    partial class frmListGenerics5
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.listBoxMes = new System.Windows.Forms.ListBox();
            this.listBoxValorBruto = new System.Windows.Forms.ListBox();
            this.listBoxLiquido = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbValor = new System.Windows.Forms.ComboBox();
            this.cbfiltros = new System.Windows.Forms.ComboBox();
            this.txtValorPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxResultados = new System.Windows.Forms.ListBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(141, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(52, 215);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(46, 22);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mês";
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(132, 35);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(122, 29);
            this.txtMes.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(12, 77);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(114, 22);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor Ganho";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(132, 70);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(122, 29);
            this.txtValor.TabIndex = 2;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(99, 112);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(27, 22);
            this.lblPorcentagem.TabIndex = 1;
            this.lblPorcentagem.Text = "%";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentagem.Location = new System.Drawing.Point(132, 105);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(122, 29);
            this.txtPorcentagem.TabIndex = 2;
            // 
            // listBoxMes
            // 
            this.listBoxMes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMes.FormattingEnabled = true;
            this.listBoxMes.ItemHeight = 18;
            this.listBoxMes.Location = new System.Drawing.Point(4, 249);
            this.listBoxMes.Name = "listBoxMes";
            this.listBoxMes.Size = new System.Drawing.Size(136, 148);
            this.listBoxMes.TabIndex = 3;
            // 
            // listBoxValorBruto
            // 
            this.listBoxValorBruto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxValorBruto.FormattingEnabled = true;
            this.listBoxValorBruto.ItemHeight = 18;
            this.listBoxValorBruto.Location = new System.Drawing.Point(146, 249);
            this.listBoxValorBruto.Name = "listBoxValorBruto";
            this.listBoxValorBruto.Size = new System.Drawing.Size(140, 148);
            this.listBoxValorBruto.TabIndex = 3;
            // 
            // listBoxLiquido
            // 
            this.listBoxLiquido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLiquido.FormattingEnabled = true;
            this.listBoxLiquido.ItemHeight = 18;
            this.listBoxLiquido.Location = new System.Drawing.Point(292, 249);
            this.listBoxLiquido.Name = "listBoxLiquido";
            this.listBoxLiquido.Size = new System.Drawing.Size(140, 148);
            this.listBoxLiquido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Bruto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Liquido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mês";
            // 
            // cbValor
            // 
            this.cbValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValor.FormattingEnabled = true;
            this.cbValor.Items.AddRange(new object[] {
            "VALOR BRUTO",
            "VALOR LIQUIDO"});
            this.cbValor.Location = new System.Drawing.Point(671, 77);
            this.cbValor.Name = "cbValor";
            this.cbValor.Size = new System.Drawing.Size(159, 30);
            this.cbValor.Sorted = true;
            this.cbValor.TabIndex = 4;
            // 
            // cbfiltros
            // 
            this.cbfiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfiltros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfiltros.FormattingEnabled = true;
            this.cbfiltros.Items.AddRange(new object[] {
            "MAIOR",
            "IGUAL",
            "MENOR"});
            this.cbfiltros.Location = new System.Drawing.Point(671, 117);
            this.cbfiltros.Name = "cbfiltros";
            this.cbfiltros.Size = new System.Drawing.Size(159, 30);
            this.cbfiltros.TabIndex = 4;
            // 
            // txtValorPesquisa
            // 
            this.txtValorPesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPesquisa.Location = new System.Drawing.Point(670, 35);
            this.txtValorPesquisa.Name = "txtValorPesquisa";
            this.txtValorPesquisa.Size = new System.Drawing.Size(160, 29);
            this.txtValorPesquisa.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor para Pesquisa";
            // 
            // listBoxResultados
            // 
            this.listBoxResultados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResultados.FormattingEnabled = true;
            this.listBoxResultados.ItemHeight = 18;
            this.listBoxResultados.Location = new System.Drawing.Point(486, 249);
            this.listBoxResultados.Name = "listBoxResultados";
            this.listBoxResultados.Size = new System.Drawing.Size(423, 148);
            this.listBoxResultados.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(703, 164);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(110, 38);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmListGenerics5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 414);
            this.Controls.Add(this.cbfiltros);
            this.Controls.Add(this.cbValor);
            this.Controls.Add(this.listBoxResultados);
            this.Controls.Add(this.listBoxLiquido);
            this.Controls.Add(this.listBoxValorBruto);
            this.Controls.Add(this.listBoxMes);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValorPesquisa);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmListGenerics5";
            this.Text = "frmListGenerics5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.ListBox listBoxMes;
        private System.Windows.Forms.ListBox listBoxValorBruto;
        private System.Windows.Forms.ListBox listBoxLiquido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbValor;
        private System.Windows.Forms.ComboBox cbfiltros;
        private System.Windows.Forms.TextBox txtValorPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxResultados;
        private System.Windows.Forms.Button btnPesquisar;
    }
}