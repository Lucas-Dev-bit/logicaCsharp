namespace logica
{
    partial class frmLinq3
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
            this.lblGrupoEtario = new System.Windows.Forms.Label();
            this.listBoxInfantil = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.cbGrupoEtario = new System.Windows.Forms.ComboBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.listBoxJuvenil = new System.Windows.Forms.ListBox();
            this.listBoxAdulto = new System.Windows.Forms.ListBox();
            this.lblInfantil = new System.Windows.Forms.Label();
            this.lblJuvenil = new System.Windows.Forms.Label();
            this.lblAdulto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGrupoPesquisa = new System.Windows.Forms.ComboBox();
            this.cbOpcaoPesquisa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlturaPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGrupoEtario
            // 
            this.lblGrupoEtario.AutoSize = true;
            this.lblGrupoEtario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoEtario.Location = new System.Drawing.Point(64, 37);
            this.lblGrupoEtario.Name = "lblGrupoEtario";
            this.lblGrupoEtario.Size = new System.Drawing.Size(117, 22);
            this.lblGrupoEtario.TabIndex = 0;
            this.lblGrupoEtario.Text = "Grupo Etário";
            // 
            // listBoxInfantil
            // 
            this.listBoxInfantil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxInfantil.FormattingEnabled = true;
            this.listBoxInfantil.ItemHeight = 22;
            this.listBoxInfantil.Location = new System.Drawing.Point(16, 220);
            this.listBoxInfantil.Name = "listBoxInfantil";
            this.listBoxInfantil.Size = new System.Drawing.Size(128, 158);
            this.listBoxInfantil.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(154, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(187, 65);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(121, 29);
            this.txtAltura.TabIndex = 3;
            // 
            // cbGrupoEtario
            // 
            this.cbGrupoEtario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupoEtario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupoEtario.FormattingEnabled = true;
            this.cbGrupoEtario.Items.AddRange(new object[] {
            "INFANTIL",
            "JUVENIL",
            "ADULTO"});
            this.cbGrupoEtario.Location = new System.Drawing.Point(187, 29);
            this.cbGrupoEtario.Name = "cbGrupoEtario";
            this.cbGrupoEtario.Size = new System.Drawing.Size(121, 30);
            this.cbGrupoEtario.TabIndex = 4;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(115, 72);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(58, 22);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // listBoxJuvenil
            // 
            this.listBoxJuvenil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxJuvenil.FormattingEnabled = true;
            this.listBoxJuvenil.ItemHeight = 22;
            this.listBoxJuvenil.Location = new System.Drawing.Point(150, 220);
            this.listBoxJuvenil.Name = "listBoxJuvenil";
            this.listBoxJuvenil.Size = new System.Drawing.Size(130, 158);
            this.listBoxJuvenil.TabIndex = 1;
            // 
            // listBoxAdulto
            // 
            this.listBoxAdulto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAdulto.FormattingEnabled = true;
            this.listBoxAdulto.ItemHeight = 22;
            this.listBoxAdulto.Location = new System.Drawing.Point(286, 220);
            this.listBoxAdulto.Name = "listBoxAdulto";
            this.listBoxAdulto.Size = new System.Drawing.Size(128, 158);
            this.listBoxAdulto.TabIndex = 1;
            // 
            // lblInfantil
            // 
            this.lblInfantil.AutoSize = true;
            this.lblInfantil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfantil.Location = new System.Drawing.Point(52, 183);
            this.lblInfantil.Name = "lblInfantil";
            this.lblInfantil.Size = new System.Drawing.Size(65, 22);
            this.lblInfantil.TabIndex = 0;
            this.lblInfantil.Text = "Infantil";
            // 
            // lblJuvenil
            // 
            this.lblJuvenil.AutoSize = true;
            this.lblJuvenil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuvenil.Location = new System.Drawing.Point(183, 183);
            this.lblJuvenil.Name = "lblJuvenil";
            this.lblJuvenil.Size = new System.Drawing.Size(68, 22);
            this.lblJuvenil.TabIndex = 0;
            this.lblJuvenil.Text = "Juvenil";
            // 
            // lblAdulto
            // 
            this.lblAdulto.AutoSize = true;
            this.lblAdulto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdulto.Location = new System.Drawing.Point(317, 183);
            this.lblAdulto.Name = "lblAdulto";
            this.lblAdulto.Size = new System.Drawing.Size(64, 22);
            this.lblAdulto.TabIndex = 0;
            this.lblAdulto.Text = "Adulto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Grupo Etário";
            // 
            // cbGrupoPesquisa
            // 
            this.cbGrupoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupoPesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupoPesquisa.FormattingEnabled = true;
            this.cbGrupoPesquisa.Items.AddRange(new object[] {
            "INFANTIL",
            "JUVENIL",
            "ADULTO"});
            this.cbGrupoPesquisa.Location = new System.Drawing.Point(677, 115);
            this.cbGrupoPesquisa.Name = "cbGrupoPesquisa";
            this.cbGrupoPesquisa.Size = new System.Drawing.Size(121, 30);
            this.cbGrupoPesquisa.TabIndex = 4;
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
            this.cbOpcaoPesquisa.Location = new System.Drawing.Point(677, 151);
            this.cbOpcaoPesquisa.Name = "cbOpcaoPesquisa";
            this.cbOpcaoPesquisa.Size = new System.Drawing.Size(121, 30);
            this.cbOpcaoPesquisa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Opção";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Altura";
            // 
            // txtAlturaPesquisa
            // 
            this.txtAlturaPesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlturaPesquisa.Location = new System.Drawing.Point(677, 193);
            this.txtAlturaPesquisa.Name = "txtAlturaPesquisa";
            this.txtAlturaPesquisa.Size = new System.Drawing.Size(121, 29);
            this.txtAlturaPesquisa.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(677, 233);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(121, 34);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opções para pesquisa";
            // 
            // frmLinq3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbOpcaoPesquisa);
            this.Controls.Add(this.cbGrupoPesquisa);
            this.Controls.Add(this.cbGrupoEtario);
            this.Controls.Add(this.txtAlturaPesquisa);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxAdulto);
            this.Controls.Add(this.listBoxJuvenil);
            this.Controls.Add(this.listBoxInfantil);
            this.Controls.Add(this.lblAdulto);
            this.Controls.Add(this.lblJuvenil);
            this.Controls.Add(this.lblInfantil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblGrupoEtario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLinq3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLinq3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrupoEtario;
        private System.Windows.Forms.ListBox listBoxInfantil;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.ComboBox cbGrupoEtario;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.ListBox listBoxJuvenil;
        private System.Windows.Forms.ListBox listBoxAdulto;
        private System.Windows.Forms.Label lblInfantil;
        private System.Windows.Forms.Label lblJuvenil;
        private System.Windows.Forms.Label lblAdulto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGrupoPesquisa;
        private System.Windows.Forms.ComboBox cbOpcaoPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlturaPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label4;
    }
}