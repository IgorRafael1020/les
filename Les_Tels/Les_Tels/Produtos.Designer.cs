namespace Les_Tels
{
    partial class Produtos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setConnection = new Les_Tels.SetConnection();
            this.produtosTableAdapter = new Les_Tels.SetConnectionTableAdapters.produtosTableAdapter();
            this.tiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposTableAdapter = new Les_Tels.SetConnectionTableAdapters.tiposTableAdapter();
            this.tableAdapterManager = new Les_Tels.SetConnectionTableAdapters.TableAdapterManager();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.producoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producoesTableAdapter = new Les_Tels.SetConnectionTableAdapters.producoesTableAdapter();
            this.dgvProducoes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirProducao = new System.Windows.Forms.Button();
            this.btnEditarProducao = new System.Windows.Forms.Button();
            this.btnNovaProducao = new System.Windows.Forms.Button();
            this.dtpDiaProducao = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnProducao = new System.Windows.Forms.Button();
            this.btnProducaoDeHoje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducoes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(600, 17);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(142, 20);
            this.txtDescricao.TabIndex = 10;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(313, 14);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(142, 23);
            this.btnExcluirProduto.TabIndex = 8;
            this.btnExcluirProduto.Text = "Excluir Produto";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(165, 14);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(142, 23);
            this.btnEditarProduto.TabIndex = 7;
            this.btnEditarProduto.Text = "Editar Produto";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(17, 14);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(142, 23);
            this.btnNovoProduto.TabIndex = 6;
            this.btnNovoProduto.Text = "Novo Produto";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdutoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.estoqueMinimoDataGridViewTextBoxColumn,
            this.dataValidadeDataGridViewTextBoxColumn,
            this.codTipoDataGridViewTextBoxColumn,
            this.codUsuarioDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.produtosBindingSource;
            this.dgvProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProdutos.Location = new System.Drawing.Point(17, 52);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1028, 198);
            this.dgvProdutos.TabIndex = 13;
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "codProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "codProduto";
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            this.codProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codProdutoDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estoqueMinimoDataGridViewTextBoxColumn
            // 
            this.estoqueMinimoDataGridViewTextBoxColumn.DataPropertyName = "estoqueMinimo";
            this.estoqueMinimoDataGridViewTextBoxColumn.HeaderText = "estoqueMinimo";
            this.estoqueMinimoDataGridViewTextBoxColumn.Name = "estoqueMinimoDataGridViewTextBoxColumn";
            this.estoqueMinimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            this.dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "dataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.HeaderText = "dataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            this.dataValidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codTipoDataGridViewTextBoxColumn
            // 
            this.codTipoDataGridViewTextBoxColumn.DataPropertyName = "codTipo";
            this.codTipoDataGridViewTextBoxColumn.HeaderText = "codTipo";
            this.codTipoDataGridViewTextBoxColumn.Name = "codTipoDataGridViewTextBoxColumn";
            this.codTipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codTipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codUsuarioDataGridViewTextBoxColumn
            // 
            this.codUsuarioDataGridViewTextBoxColumn.DataPropertyName = "codUsuario";
            this.codUsuarioDataGridViewTextBoxColumn.HeaderText = "codUsuario";
            this.codUsuarioDataGridViewTextBoxColumn.Name = "codUsuarioDataGridViewTextBoxColumn";
            this.codUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.codUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.setConnection;
            // 
            // setConnection
            // 
            this.setConnection.DataSetName = "SetConnection";
            this.setConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tiposBindingSource
            // 
            this.tiposBindingSource.DataMember = "tipos";
            this.tiposBindingSource.DataSource = this.setConnection;
            // 
            // tiposTableAdapter
            // 
            this.tiposTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.itensSolicitacaoTableAdapter = null;
            this.tableAdapterManager.producoesTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.solicitacoesTableAdapter = null;
            this.tableAdapterManager.tiposTableAdapter = this.tiposTableAdapter;
            this.tableAdapterManager.UpdateOrder = Les_Tels.SetConnectionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tiposBindingSource, "tipo", true));
            this.cmbTipo.DataSource = this.tiposBindingSource;
            this.cmbTipo.DisplayMember = "tipo";
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(461, 16);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 15;
            this.cmbTipo.ValueMember = "codTipo";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // producoesBindingSource
            // 
            this.producoesBindingSource.DataMember = "producoes";
            this.producoesBindingSource.DataSource = this.setConnection;
            // 
            // producoesTableAdapter
            // 
            this.producoesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvProducoes
            // 
            this.dgvProducoes.AllowUserToAddRows = false;
            this.dgvProducoes.AllowUserToDeleteRows = false;
            this.dgvProducoes.AllowUserToResizeColumns = false;
            this.dgvProducoes.AllowUserToResizeRows = false;
            this.dgvProducoes.AutoGenerateColumns = false;
            this.dgvProducoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgvProducoes.DataSource = this.producoesBindingSource;
            this.dgvProducoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProducoes.Location = new System.Drawing.Point(17, 295);
            this.dgvProducoes.MultiSelect = false;
            this.dgvProducoes.Name = "dgvProducoes";
            this.dgvProducoes.ReadOnly = true;
            this.dgvProducoes.RowHeadersVisible = false;
            this.dgvProducoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducoes.Size = new System.Drawing.Size(1028, 220);
            this.dgvProducoes.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "codProducao";
            this.dataGridViewTextBoxColumn10.HeaderText = "codProducao";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "codProduto";
            this.dataGridViewTextBoxColumn11.HeaderText = "codProduto";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "dataProducao";
            this.dataGridViewTextBoxColumn12.HeaderText = "dataProducao";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn13.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "codUsuario";
            this.dataGridViewTextBoxColumn14.HeaderText = "codUsuario";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // btnExcluirProducao
            // 
            this.btnExcluirProducao.Location = new System.Drawing.Point(313, 266);
            this.btnExcluirProducao.Name = "btnExcluirProducao";
            this.btnExcluirProducao.Size = new System.Drawing.Size(142, 23);
            this.btnExcluirProducao.TabIndex = 19;
            this.btnExcluirProducao.Text = "Excluir Produção";
            this.btnExcluirProducao.UseVisualStyleBackColor = true;
            this.btnExcluirProducao.Click += new System.EventHandler(this.btnExcluirProducao_Click);
            // 
            // btnEditarProducao
            // 
            this.btnEditarProducao.Location = new System.Drawing.Point(165, 266);
            this.btnEditarProducao.Name = "btnEditarProducao";
            this.btnEditarProducao.Size = new System.Drawing.Size(142, 23);
            this.btnEditarProducao.TabIndex = 18;
            this.btnEditarProducao.Text = "Editar Produção";
            this.btnEditarProducao.UseVisualStyleBackColor = true;
            this.btnEditarProducao.Click += new System.EventHandler(this.btnEditarProducao_Click);
            // 
            // btnNovaProducao
            // 
            this.btnNovaProducao.Location = new System.Drawing.Point(17, 266);
            this.btnNovaProducao.Name = "btnNovaProducao";
            this.btnNovaProducao.Size = new System.Drawing.Size(142, 23);
            this.btnNovaProducao.TabIndex = 17;
            this.btnNovaProducao.Text = "Nova Produção";
            this.btnNovaProducao.UseVisualStyleBackColor = true;
            this.btnNovaProducao.Click += new System.EventHandler(this.btnNovaProducao_Click);
            // 
            // dtpDiaProducao
            // 
            this.dtpDiaProducao.CustomFormat = "";
            this.dtpDiaProducao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiaProducao.Location = new System.Drawing.Point(461, 269);
            this.dtpDiaProducao.Name = "dtpDiaProducao";
            this.dtpDiaProducao.Size = new System.Drawing.Size(100, 20);
            this.dtpDiaProducao.TabIndex = 20;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(829, 14);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(748, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnProducao
            // 
            this.btnProducao.Location = new System.Drawing.Point(567, 266);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(75, 23);
            this.btnProducao.TabIndex = 24;
            this.btnProducao.Text = "Pesquisar";
            this.btnProducao.UseVisualStyleBackColor = true;
            this.btnProducao.Click += new System.EventHandler(this.btnProducao_Click);
            // 
            // btnProducaoDeHoje
            // 
            this.btnProducaoDeHoje.Location = new System.Drawing.Point(648, 266);
            this.btnProducaoDeHoje.Name = "btnProducaoDeHoje";
            this.btnProducaoDeHoje.Size = new System.Drawing.Size(112, 23);
            this.btnProducaoDeHoje.TabIndex = 25;
            this.btnProducaoDeHoje.Text = "Produção de Hoje";
            this.btnProducaoDeHoje.UseVisualStyleBackColor = true;
            this.btnProducaoDeHoje.Click += new System.EventHandler(this.btnProducaoAtual_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProducaoDeHoje);
            this.Controls.Add(this.btnProducao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtpDiaProducao);
            this.Controls.Add(this.btnExcluirProducao);
            this.Controls.Add(this.btnEditarProducao);
            this.Controls.Add(this.btnNovaProducao);
            this.Controls.Add(this.dgvProducoes);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnNovoProduto);
            this.Name = "Produtos";
            this.Size = new System.Drawing.Size(1110, 540);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private SetConnection setConnection;
        private SetConnectionTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tiposBindingSource;
        private SetConnectionTableAdapters.tiposTableAdapter tiposTableAdapter;
        private SetConnectionTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.BindingSource producoesBindingSource;
        private SetConnectionTableAdapters.producoesTableAdapter producoesTableAdapter;
        private System.Windows.Forms.DataGridView dgvProducoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button btnExcluirProducao;
        private System.Windows.Forms.Button btnEditarProducao;
        private System.Windows.Forms.Button btnNovaProducao;
        private System.Windows.Forms.DateTimePicker dtpDiaProducao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnProducao;
        private System.Windows.Forms.Button btnProducaoDeHoje;
    }
}
