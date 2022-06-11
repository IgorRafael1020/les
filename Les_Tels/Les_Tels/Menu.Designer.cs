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
            this.lblVendas = new System.Windows.Forms.Label();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.rbtnMenu = new CustomControls.RoundButtonControls.RoundButton();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblFornecedores = new System.Windows.Forms.Label();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.btnVendas = new System.Windows.Forms.Button();
            this.pnlJanelas = new System.Windows.Forms.Panel();
            this.usuarios1 = new Les_Tels.Usuarios();
            this.vendas1 = new Les_Tels.Vendas();
            this.produtos1 = new Les_Tels.Produtos();
            this.fornecedor1 = new Les_Tels.Fornecedor();
            this.pnlTopo.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            this.pnlJanelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Location = new System.Drawing.Point(51, 195);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(43, 13);
            this.lblVendas.TabIndex = 9;
            this.lblVendas.Text = "Vendas";
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
            this.pnlBarra.Controls.Add(this.rbtnMenu);
            this.pnlBarra.Controls.Add(this.btnUsuarios);
            this.pnlBarra.Controls.Add(this.btnFornecedores);
            this.pnlBarra.Controls.Add(this.btnRelatorios);
            this.pnlBarra.Controls.Add(this.btnPedidos);
            this.pnlBarra.Controls.Add(this.btnCaixa);
            this.pnlBarra.Controls.Add(this.btnProdutos);
            this.pnlBarra.Controls.Add(this.lblUsuarios);
            this.pnlBarra.Controls.Add(this.lblFornecedores);
            this.pnlBarra.Controls.Add(this.lblRelatorios);
            this.pnlBarra.Controls.Add(this.lblPedidos);
            this.pnlBarra.Controls.Add(this.lblCaixa);
            this.pnlBarra.Controls.Add(this.lblProdutos);
            this.pnlBarra.Controls.Add(this.btnVendas);
            this.pnlBarra.Controls.Add(this.lblVendas);
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(144, 682);
            this.pnlBarra.TabIndex = 0;
            // 
            // rbtnMenu
            // 
            this.rbtnMenu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnMenu.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnMenu.BackgroundImage = global::Les_Tels.Properties.Resources._4_1;
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
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BackgroundImage = global::Les_Tels.Properties.Resources.Usuários_Cinza_Preto;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Location = new System.Drawing.Point(14, 575);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(112, 52);
            this.btnUsuarios.TabIndex = 22;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
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
            this.btnFornecedores.Location = new System.Drawing.Point(14, 505);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(112, 52);
            this.btnFornecedores.TabIndex = 21;
            this.btnFornecedores.UseVisualStyleBackColor = false;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
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
            this.btnRelatorios.Location = new System.Drawing.Point(14, 432);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(112, 52);
            this.btnRelatorios.TabIndex = 20;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.BackgroundImage = global::Les_Tels.Properties.Resources.Pedidos_Cinza_Preto;
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Location = new System.Drawing.Point(14, 361);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(112, 52);
            this.btnPedidos.TabIndex = 19;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
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
            this.btnCaixa.Location = new System.Drawing.Point(14, 290);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(112, 52);
            this.btnCaixa.TabIndex = 18;
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
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
            this.btnProdutos.Location = new System.Drawing.Point(14, 215);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(112, 52);
            this.btnProdutos.TabIndex = 17;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(51, 630);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(48, 13);
            this.lblUsuarios.TabIndex = 16;
            this.lblUsuarios.Text = "Usuários";
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Location = new System.Drawing.Point(51, 559);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(72, 13);
            this.lblFornecedores.TabIndex = 15;
            this.lblFornecedores.Text = "Fornecedores";
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Location = new System.Drawing.Point(51, 489);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(54, 13);
            this.lblRelatorios.TabIndex = 14;
            this.lblRelatorios.Text = "Relatórios";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(51, 416);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(45, 13);
            this.lblPedidos.TabIndex = 13;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Location = new System.Drawing.Point(51, 345);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(33, 13);
            this.lblCaixa.TabIndex = 12;
            this.lblCaixa.Text = "Caixa";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(51, 270);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(49, 13);
            this.lblProdutos.TabIndex = 11;
            this.lblProdutos.Text = "Produtos";
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.Transparent;
            this.btnVendas.BackgroundImage = global::Les_Tels.Properties.Resources.Vendas_Cinza_Preto;
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVendas.Location = new System.Drawing.Point(14, 140);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(112, 52);
            this.btnVendas.TabIndex = 0;
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // pnlJanelas
            // 
            this.pnlJanelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.pnlJanelas.BackgroundImage = global::Les_Tels.Properties.Resources._4_1_r;
            this.pnlJanelas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlJanelas.Controls.Add(this.fornecedor1);
            this.pnlJanelas.Controls.Add(this.usuarios1);
            this.pnlJanelas.Controls.Add(this.vendas1);
            this.pnlJanelas.Controls.Add(this.produtos1);
            this.pnlJanelas.Location = new System.Drawing.Point(144, 126);
            this.pnlJanelas.Name = "pnlJanelas";
            this.pnlJanelas.Size = new System.Drawing.Size(1119, 555);
            this.pnlJanelas.TabIndex = 2;
            // 
            // usuarios1
            // 
            this.usuarios1.Location = new System.Drawing.Point(0, 0);
            this.usuarios1.Name = "usuarios1";
            this.usuarios1.Size = new System.Drawing.Size(1116, 555);
            this.usuarios1.TabIndex = 2;
            // 
            // vendas1
            // 
            this.vendas1.Location = new System.Drawing.Point(0, 0);
            this.vendas1.Name = "vendas1";
            this.vendas1.Size = new System.Drawing.Size(1110, 540);
            this.vendas1.TabIndex = 1;
            // 
            // produtos1
            // 
            this.produtos1.Location = new System.Drawing.Point(-2, 3);
            this.produtos1.Name = "produtos1";
            this.produtos1.Size = new System.Drawing.Size(1118, 552);
            this.produtos1.TabIndex = 0;
            // 
            // fornecedor1
            // 
            this.fornecedor1.Location = new System.Drawing.Point(6, 12);
            this.fornecedor1.Name = "fornecedor1";
            this.fornecedor1.Size = new System.Drawing.Size(1110, 540);
            this.fornecedor1.TabIndex = 3;
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
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.pnlJanelas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlJanelas;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblFornecedores;
        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Label lblTitulo;
        private CustomControls.RoundButtonControls.RoundButton rbtnMenu;
        private Produtos produtos1;
        private Vendas vendas1;
        private Usuarios usuarios1;
        private Fornecedor fornecedor1;
    }
}