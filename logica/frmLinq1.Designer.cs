namespace logica
{
    partial class frmLinq1
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.listBoxAdidas = new System.Windows.Forms.ListBox();
            this.listBoxNike = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFiltroMarca = new System.Windows.Forms.ComboBox();
            this.txtNumeroReferencia = new System.Windows.Forms.TextBox();
            this.btnLinqConsulta = new System.Windows.Forms.Button();
            this.btnLinqMetodo = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFiltroTamanho = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(404, 102);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(146, 22);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Filtrar por Marca";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "ADIDAS",
            "NIKE\t"});
            this.cbMarca.Location = new System.Drawing.Point(143, 15);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 30);
            this.cbMarca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(143, 54);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 29);
            this.txtNumero.TabIndex = 2;
            // 
            // listBoxAdidas
            // 
            this.listBoxAdidas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAdidas.FormattingEnabled = true;
            this.listBoxAdidas.ItemHeight = 22;
            this.listBoxAdidas.Location = new System.Drawing.Point(11, 195);
            this.listBoxAdidas.Name = "listBoxAdidas";
            this.listBoxAdidas.Size = new System.Drawing.Size(149, 202);
            this.listBoxAdidas.TabIndex = 3;
            // 
            // listBoxNike
            // 
            this.listBoxNike.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNike.FormattingEnabled = true;
            this.listBoxNike.ItemHeight = 22;
            this.listBoxNike.Location = new System.Drawing.Point(166, 195);
            this.listBoxNike.Name = "listBoxNike";
            this.listBoxNike.Size = new System.Drawing.Size(151, 202);
            this.listBoxNike.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número para pesquisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marca";
            // 
            // cbFiltroMarca
            // 
            this.cbFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroMarca.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroMarca.FormattingEnabled = true;
            this.cbFiltroMarca.Items.AddRange(new object[] {
            "ADIDAS",
            "NIKE\t"});
            this.cbFiltroMarca.Location = new System.Drawing.Point(572, 99);
            this.cbFiltroMarca.Name = "cbFiltroMarca";
            this.cbFiltroMarca.Size = new System.Drawing.Size(121, 30);
            this.cbFiltroMarca.TabIndex = 1;
            // 
            // txtNumeroReferencia
            // 
            this.txtNumeroReferencia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroReferencia.Location = new System.Drawing.Point(572, 182);
            this.txtNumeroReferencia.Name = "txtNumeroReferencia";
            this.txtNumeroReferencia.Size = new System.Drawing.Size(121, 29);
            this.txtNumeroReferencia.TabIndex = 2;
            // 
            // btnLinqConsulta
            // 
            this.btnLinqConsulta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinqConsulta.Location = new System.Drawing.Point(426, 238);
            this.btnLinqConsulta.Name = "btnLinqConsulta";
            this.btnLinqConsulta.Size = new System.Drawing.Size(225, 34);
            this.btnLinqConsulta.TabIndex = 4;
            this.btnLinqConsulta.Text = "Pesquisar Consulta";
            this.btnLinqConsulta.UseVisualStyleBackColor = true;
            this.btnLinqConsulta.Click += new System.EventHandler(this.btnLinqConsulta_Click);
            // 
            // btnLinqMetodo
            // 
            this.btnLinqMetodo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinqMetodo.Location = new System.Drawing.Point(426, 290);
            this.btnLinqMetodo.Name = "btnLinqMetodo";
            this.btnLinqMetodo.Size = new System.Drawing.Size(225, 32);
            this.btnLinqMetodo.TabIndex = 4;
            this.btnLinqMetodo.Text = "Pesquisar Metodo";
            this.btnLinqMetodo.UseVisualStyleBackColor = true;
            this.btnLinqMetodo.Click += new System.EventHandler(this.btnLinqMetodo_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(103, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adidas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nike";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Filtrar por tamanho";
            // 
            // cbFiltroTamanho
            // 
            this.cbFiltroTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroTamanho.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroTamanho.FormattingEnabled = true;
            this.cbFiltroTamanho.Items.AddRange(new object[] {
            "ACIMA",
            "IGUAL",
            "ABAIXO"});
            this.cbFiltroTamanho.Location = new System.Drawing.Point(572, 140);
            this.cbFiltroTamanho.Name = "cbFiltroTamanho";
            this.cbFiltroTamanho.Size = new System.Drawing.Size(121, 30);
            this.cbFiltroTamanho.TabIndex = 1;
            // 
            // frmLinq1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.btnLinqMetodo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLinqConsulta);
            this.Controls.Add(this.listBoxNike);
            this.Controls.Add(this.listBoxAdidas);
            this.Controls.Add(this.txtNumeroReferencia);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cbFiltroTamanho);
            this.Controls.Add(this.cbFiltroMarca);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMarca);
            this.Name = "frmLinq1";
            this.Text = "frmLinq1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListBox listBoxAdidas;
        private System.Windows.Forms.ListBox listBoxNike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFiltroMarca;
        private System.Windows.Forms.TextBox txtNumeroReferencia;
        private System.Windows.Forms.Button btnLinqConsulta;
        private System.Windows.Forms.Button btnLinqMetodo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFiltroTamanho;
    }
}