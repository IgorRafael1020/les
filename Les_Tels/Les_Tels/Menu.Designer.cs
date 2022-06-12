namespace Les_Tels
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblVendas = new System.Windows.Forms.Label();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.pnlFornecedores = new System.Windows.Forms.Panel();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.lblFornecedores = new System.Windows.Forms.Label();
            this.pnlRelatorios = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.pnlSolicitacoes = new System.Windows.Forms.Panel();
            this.btnSolicitacoes = new System.Windows.Forms.Button();
            this.lblSolicitacoes = new System.Windows.Forms.Label();
            this.pnlCaixa = new System.Windows.Forms.Panel();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.pnlVendas = new System.Windows.Forms.Panel();
            this.btnVendas = new System.Windows.Forms.Button();
            this.rbtnMenu = new CustomControls.RoundButtonControls.RoundButton();
            this.pnlJanelas = new System.Windows.Forms.Panel();
            this.pnlTopo.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            this.pnlUsuarios.SuspendLayout();
            this.pnlFornecedores.SuspendLayout();
            this.pnlRelatorios.SuspendLayout();
            this.pnlSolicitacoes.SuspendLayout();
            this.pnlCaixa.SuspendLayout();
            this.pnlProdutos.SuspendLayout();
            this.pnlVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Location = new System.Drawing.Point(20, 52);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(43, 13);
            this.lblVendas.TabIndex = 9;
            this.lblVendas.Text = "Vendas";
            this.lblVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(59)))), ((int)(((byte)(14)))));
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Location = new System.Drawing.Point(144, -2);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1119, 128);
            this.pnlTopo.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(169)))), ((int)(((byte)(77)))));
            this.lblTitulo.Location = new System.Drawing.Point(247, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(542, 73);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cantinho do Trigo";
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(59)))), ((int)(((byte)(14)))));
            this.pnlBarra.Controls.Add(this.pnlUsuarios);
            this.pnlBarra.Controls.Add(this.pnlFornecedores);
            this.pnlBarra.Controls.Add(this.pnlRelatorios);
            this.pnlBarra.Controls.Add(this.pnlSolicitacoes);
            this.pnlBarra.Controls.Add(this.pnlCaixa);
            this.pnlBarra.Controls.Add(this.pnlProdutos);
            this.pnlBarra.Controls.Add(this.pnlVendas);
            this.pnlBarra.Controls.Add(this.rbtnMenu);
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(144, 682);
            this.pnlBarra.TabIndex = 0;
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsuarios.Controls.Add(this.btnUsuarios);
            this.pnlUsuarios.Controls.Add(this.lblUsuarios);
            this.pnlUsuarios.Location = new System.Drawing.Point(30, 596);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(80, 70);
            this.pnlUsuarios.TabIndex = 24;
            this.pnlUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BackgroundImage = global::Les_Tels.Properties.Resources.Usuários_Cinza_Preto;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Location = new System.Drawing.Point(-1, -1);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(80, 50);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(15, 52);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(48, 13);
            this.lblUsuarios.TabIndex = 9;
            this.lblUsuarios.Text = "Usuários";
            this.lblUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pnlFornecedores
            // 
            this.pnlFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFornecedores.Controls.Add(this.btnFornecedores);
            this.pnlFornecedores.Controls.Add(this.lblFornecedores);
            this.pnlFornecedores.Location = new System.Drawing.Point(30, 520);
            this.pnlFornecedores.Name = "pnlFornecedores";
            this.pnlFornecedores.Size = new System.Drawing.Size(80, 70);
            this.pnlFornecedores.TabIndex = 24;
            this.pnlFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.BackColor = System.Drawing.Color.Transparent;
            this.btnFornecedores.BackgroundImage = global::Les_Tels.Properties.Resources.Fornecedor_Cinza_Preto;
            this.btnFornecedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFornecedores.FlatAppearance.BorderSize = 0;
            this.btnFornecedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Location = new System.Drawing.Point(-1, -1);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(80, 50);
            this.btnFornecedores.TabIndex = 0;
            this.btnFornecedores.UseVisualStyleBackColor = false;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Location = new System.Drawing.Point(5, 52);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(72, 13);
            this.lblFornecedores.TabIndex = 9;
            this.lblFornecedores.Text = "Fornecedores";
            this.lblFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // pnlRelatorios
            // 
            this.pnlRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRelatorios.Controls.Add(this.btnRelatorios);
            this.pnlRelatorios.Controls.Add(this.lblRelatorios);
            this.pnlRelatorios.Location = new System.Drawing.Point(30, 444);
            this.pnlRelatorios.Name = "pnlRelatorios";
            this.pnlRelatorios.Size = new System.Drawing.Size(80, 70);
            this.pnlRelatorios.TabIndex = 24;
            this.pnlRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.BackgroundImage = global::Les_Tels.Properties.Resources.Relatório_Cinza_Preto;
            this.btnRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Location = new System.Drawing.Point(-1, -1);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(80, 50);
            this.btnRelatorios.TabIndex = 0;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Location = new System.Drawing.Point(12, 52);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(54, 13);
            this.lblRelatorios.TabIndex = 9;
            this.lblRelatorios.Text = "Relatórios";
            this.lblRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // pnlSolicitacoes
            // 
            this.pnlSolicitacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSolicitacoes.Controls.Add(this.btnSolicitacoes);
            this.pnlSolicitacoes.Controls.Add(this.lblSolicitacoes);
            this.pnlSolicitacoes.Location = new System.Drawing.Point(30, 368);
            this.pnlSolicitacoes.Name = "pnlSolicitacoes";
            this.pnlSolicitacoes.Size = new System.Drawing.Size(80, 70);
            this.pnlSolicitacoes.TabIndex = 24;
            this.pnlSolicitacoes.Click += new System.EventHandler(this.btnSolicitacoes_Click);
            // 
            // btnSolicitacoes
            // 
            this.btnSolicitacoes.BackColor = System.Drawing.Color.Transparent;
            this.btnSolicitacoes.BackgroundImage = global::Les_Tels.Properties.Resources.Solicitações_Cinza_Preto;
            this.btnSolicitacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSolicitacoes.FlatAppearance.BorderSize = 0;
            this.btnSolicitacoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSolicitacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSolicitacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitacoes.Location = new System.Drawing.Point(-1, -1);
            this.btnSolicitacoes.Name = "btnSolicitacoes";
            this.btnSolicitacoes.Size = new System.Drawing.Size(80, 50);
            this.btnSolicitacoes.TabIndex = 0;
            this.btnSolicitacoes.UseVisualStyleBackColor = false;
            this.btnSolicitacoes.Click += new System.EventHandler(this.btnSolicitacoes_Click);
            // 
            // lblSolicitacoes
            // 
            this.lblSolicitacoes.AutoSize = true;
            this.lblSolicitacoes.Location = new System.Drawing.Point(11, 52);
            this.lblSolicitacoes.Name = "lblSolicitacoes";
            this.lblSolicitacoes.Size = new System.Drawing.Size(64, 13);
            this.lblSolicitacoes.TabIndex = 9;
            this.lblSolicitacoes.Text = "Solicitações";
            this.lblSolicitacoes.Click += new System.EventHandler(this.btnSolicitacoes_Click);
            // 
            // pnlCaixa
            // 
            this.pnlCaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCaixa.Controls.Add(this.btnCaixa);
            this.pnlCaixa.Controls.Add(this.lblCaixa);
            this.pnlCaixa.Location = new System.Drawing.Point(30, 292);
            this.pnlCaixa.Name = "pnlCaixa";
            this.pnlCaixa.Size = new System.Drawing.Size(80, 70);
            this.pnlCaixa.TabIndex = 24;
            this.pnlCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.Transparent;
            this.btnCaixa.BackgroundImage = global::Les_Tels.Properties.Resources.Caixa_Cinza_Preto;
            this.btnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Location = new System.Drawing.Point(-1, -1);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(80, 50);
            this.btnCaixa.TabIndex = 0;
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Location = new System.Drawing.Point(23, 52);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(33, 13);
            this.lblCaixa.TabIndex = 9;
            this.lblCaixa.Text = "Caixa";
            this.lblCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProdutos.Controls.Add(this.btnProdutos);
            this.pnlProdutos.Controls.Add(this.lblProdutos);
            this.pnlProdutos.Location = new System.Drawing.Point(30, 216);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(80, 70);
            this.pnlProdutos.TabIndex = 24;
            this.pnlProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btnProdutos.BackgroundImage = global::Les_Tels.Properties.Resources.Produtos_Cinza_Preto;
            this.btnProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Location = new System.Drawing.Point(-1, -1);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(80, 50);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(17, 52);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(49, 13);
            this.lblProdutos.TabIndex = 9;
            this.lblProdutos.Text = "Produtos";
            this.lblProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // pnlVendas
            // 
            this.pnlVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVendas.Controls.Add(this.btnVendas);
            this.pnlVendas.Controls.Add(this.lblVendas);
            this.pnlVendas.Location = new System.Drawing.Point(30, 140);
            this.pnlVendas.Name = "pnlVendas";
            this.pnlVendas.Size = new System.Drawing.Size(80, 70);
            this.pnlVendas.TabIndex = 23;
            this.pnlVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.Transparent;
            this.btnVendas.BackgroundImage = global::Les_Tels.Properties.Resources.Vendas_Cinza_Preto;
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Location = new System.Drawing.Point(-1, -1);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(80, 50);
            this.btnVendas.TabIndex = 0;
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // rbtnMenu
            // 
            this.rbtnMenu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnMenu.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnMenu.BackgroundImage = global::Les_Tels.Properties.Resources._4_1_r;
            this.rbtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtnMenu.BorderColor = System.Drawing.Color.Black;
            this.rbtnMenu.BorderRadius = 55;
            this.rbtnMenu.BorderSize = 2;
            this.rbtnMenu.FlatAppearance.BorderSize = 0;
            this.rbtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnMenu.ForeColor = System.Drawing.Color.White;
            this.rbtnMenu.Location = new System.Drawing.Point(14, 10);
            this.rbtnMenu.Name = "rbtnMenu";
            this.rbtnMenu.Size = new System.Drawing.Size(112, 112);
            this.rbtnMenu.TabIndex = 0;
            this.rbtnMenu.TextColor = System.Drawing.Color.White;
            this.rbtnMenu.UseVisualStyleBackColor = false;
            this.rbtnMenu.Click += new System.EventHandler(this.rbtnMenu_Click);
            // 
            // pnlJanelas
            // 
            this.pnlJanelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.pnlJanelas.BackgroundImage = global::Les_Tels.Properties.Resources._4_1_rb;
            this.pnlJanelas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlJanelas.Location = new System.Drawing.Point(144, 126);
            this.pnlJanelas.Name = "pnlJanelas";
            this.pnlJanelas.Size = new System.Drawing.Size(1119, 555);
            this.pnlJanelas.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.pnlJanelas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantinho do Trigo";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlBarra.ResumeLayout(false);
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.pnlFornecedores.ResumeLayout(false);
            this.pnlFornecedores.PerformLayout();
            this.pnlRelatorios.ResumeLayout(false);
            this.pnlRelatorios.PerformLayout();
            this.pnlSolicitacoes.ResumeLayout(false);
            this.pnlSolicitacoes.PerformLayout();
            this.pnlCaixa.ResumeLayout(false);
            this.pnlCaixa.PerformLayout();
            this.pnlProdutos.ResumeLayout(false);
            this.pnlProdutos.PerformLayout();
            this.pnlVendas.ResumeLayout(false);
            this.pnlVendas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlJanelas;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblTitulo;
        private CustomControls.RoundButtonControls.RoundButton rbtnMenu;
        private System.Windows.Forms.Panel pnlVendas;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Panel pnlFornecedores;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Label lblFornecedores;
        private System.Windows.Forms.Panel pnlRelatorios;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.Panel pnlSolicitacoes;
        private System.Windows.Forms.Button btnSolicitacoes;
        private System.Windows.Forms.Label lblSolicitacoes;
        private System.Windows.Forms.Panel pnlCaixa;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Panel pnlProdutos;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Label lblProdutos;
    }
}