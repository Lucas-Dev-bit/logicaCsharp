namespace logica
{
    partial class frmLinq4
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
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.listBoxSaoPaulo = new System.Windows.Forms.ListBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblSaoPaulo = new System.Windows.Forms.Label();
            this.lblRio = new System.Windows.Forms.Label();
            this.listBoxRio = new System.Windows.Forms.ListBox();
            this.lblCuritba = new System.Windows.Forms.Label();
            this.listBoxCuritiba = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperaturaPesquisa = new System.Windows.Forms.TextBox();
            this.cbCidadePesquisa = new System.Windows.Forms.ComboBox();
            this.lblOpcoes = new System.Windows.Forms.Label();
            this.cbOpcaoPesquisa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(148, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(66, 36);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(76, 22);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.Location = new System.Drawing.Point(148, 79);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(113, 29);
            this.txtTemperatura.TabIndex = 2;
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Curitiba"});
            this.cbCidade.Location = new System.Drawing.Point(148, 28);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(186, 30);
            this.cbCidade.TabIndex = 3;
            // 
            // listBoxSaoPaulo
            // 
            this.listBoxSaoPaulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSaoPaulo.FormattingEnabled = true;
            this.listBoxSaoPaulo.ItemHeight = 22;
            this.listBoxSaoPaulo.Location = new System.Drawing.Point(25, 227);
            this.listBoxSaoPaulo.Name = "listBoxSaoPaulo";
            this.listBoxSaoPaulo.Size = new System.Drawing.Size(145, 158);
            this.listBoxSaoPaulo.TabIndex = 4;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(21, 86);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(121, 22);
            this.lblTemperatura.TabIndex = 1;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // lblSaoPaulo
            // 
            this.lblSaoPaulo.AutoSize = true;
            this.lblSaoPaulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaoPaulo.Location = new System.Drawing.Point(56, 191);
            this.lblSaoPaulo.Name = "lblSaoPaulo";
            this.lblSaoPaulo.Size = new System.Drawing.Size(97, 22);
            this.lblSaoPaulo.TabIndex = 1;
            this.lblSaoPaulo.Text = "São Paulo";
            // 
            // lblRio
            // 
            this.lblRio.AutoSize = true;
            this.lblRio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRio.Location = new System.Drawing.Point(192, 191);
            this.lblRio.Name = "lblRio";
            this.lblRio.Size = new System.Drawing.Size(133, 22);
            this.lblRio.TabIndex = 1;
            this.lblRio.Text = "Rio de Janeiro";
            // 
            // listBoxRio
            // 
            this.listBoxRio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRio.FormattingEnabled = true;
            this.listBoxRio.ItemHeight = 22;
            this.listBoxRio.Location = new System.Drawing.Point(183, 227);
            this.listBoxRio.Name = "listBoxRio";
            this.listBoxRio.Size = new System.Drawing.Size(145, 158);
            this.listBoxRio.TabIndex = 4;
            // 
            // lblCuritba
            // 
            this.lblCuritba.AutoSize = true;
            this.lblCuritba.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuritba.Location = new System.Drawing.Point(370, 191);
            this.lblCuritba.Name = "lblCuritba";
            this.lblCuritba.Size = new System.Drawing.Size(74, 22);
            this.lblCuritba.TabIndex = 1;
            this.lblCuritba.Text = "Curitiba";
            // 
            // listBoxCuritiba
            // 
            this.listBoxCuritiba.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCuritiba.FormattingEnabled = true;
            this.listBoxCuritiba.ItemHeight = 22;
            this.listBoxCuritiba.Location = new System.Drawing.Point(339, 227);
            this.listBoxCuritiba.Name = "listBoxCuritiba";
            this.listBoxCuritiba.Size = new System.Drawing.Size(145, 158);
            this.listBoxCuritiba.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura:";
            // 
            // txtTemperaturaPesquisa
            // 
            this.txtTemperaturaPesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperaturaPesquisa.Location = new System.Drawing.Point(652, 216);
            this.txtTemperaturaPesquisa.Name = "txtTemperaturaPesquisa";
            this.txtTemperaturaPesquisa.Size = new System.Drawing.Size(113, 29);
            this.txtTemperaturaPesquisa.TabIndex = 2;
            // 
            // cbCidadePesquisa
            // 
            this.cbCidadePesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidadePesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidadePesquisa.FormattingEnabled = true;
            this.cbCidadePesquisa.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Curitiba"});
            this.cbCidadePesquisa.Location = new System.Drawing.Point(652, 131);
            this.cbCidadePesquisa.Name = "cbCidadePesquisa";
            this.cbCidadePesquisa.Size = new System.Drawing.Size(186, 30);
            this.cbCidadePesquisa.TabIndex = 3;
            // 
            // lblOpcoes
            // 
            this.lblOpcoes.AutoSize = true;
            this.lblOpcoes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcoes.Location = new System.Drawing.Point(570, 178);
            this.lblOpcoes.Name = "lblOpcoes";
            this.lblOpcoes.Size = new System.Drawing.Size(83, 22);
            this.lblOpcoes.TabIndex = 1;
            this.lblOpcoes.Text = "Opções:";
            // 
            // cbOpcaoPesquisa
            // 
            this.cbOpcaoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcaoPesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcaoPesquisa.FormattingEnabled = true;
            this.cbOpcaoPesquisa.Items.AddRange(new object[] {
            "ACIMA",
            "IGUAL",
            "ABAIXO"});
            this.cbOpcaoPesquisa.Location = new System.Drawing.Point(652, 170);
            this.cbOpcaoPesquisa.Name = "cbOpcaoPesquisa";
            this.cbOpcaoPesquisa.Size = new System.Drawing.Size(186, 30);
            this.cbOpcaoPesquisa.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(652, 267);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(113, 41);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmLinq4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 406);
            this.Controls.Add(this.listBoxCuritiba);
            this.Controls.Add(this.listBoxRio);
            this.Controls.Add(this.listBoxSaoPaulo);
            this.Controls.Add(this.cbOpcaoPesquisa);
            this.Controls.Add(this.cbCidadePesquisa);
            this.Controls.Add(this.txtTemperaturaPesquisa);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblCuritba);
            this.Controls.Add(this.lblOpcoes);
            this.Controls.Add(this.lblRio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaoPaulo);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmLinq4";
            this.Text = "frmLinq4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ListBox listBoxSaoPaulo;
        internal System.Windows.Forms.Label lblCidade;
        internal System.Windows.Forms.Label lblTemperatura;
        internal System.Windows.Forms.Label lblSaoPaulo;
        internal System.Windows.Forms.Label lblRio;
        private System.Windows.Forms.ListBox listBoxRio;
        internal System.Windows.Forms.Label lblCuritba;
        private System.Windows.Forms.ListBox listBoxCuritiba;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemperaturaPesquisa;
        private System.Windows.Forms.ComboBox cbCidadePesquisa;
        internal System.Windows.Forms.Label lblOpcoes;
        private System.Windows.Forms.ComboBox cbOpcaoPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
    }
}